using LiveCharts;
using LiveCharts.Wpf;
using MetroFramework;
using Newtonsoft.Json;
using SmartMonitor.Business;
using SmartMonitor.Models.Metrics;
using SmartMonitor.Models.Operations;
using SmartMonitor.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartMonitor.UI
{
    public partial class SmartMonitor : MetroFramework.Forms.MetroForm
    {
        private MetricDefinitionService MetricDefinitionService { get; set; }
        private ResourceService ResourceService { get; set; }

        public SmartMonitor()
        {
            MetricDefinitionService = new MetricDefinitionService();
            ResourceService = new ResourceService();
            this.components = new System.ComponentModel.Container();
            InitializeComponent();
            this.components.SetStyle(this);
            this.components.SetDefaultTheme(this, MetroThemeStyle.Light);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadOperations();
            LoadWebsiteTab();
            LoadVirtualMachineTab();
            LoadStorageAccountsTab();
        }

        #region Website
        private void LoadWebsiteTab()
        {
            //UI
            webMetricsList.BeginUpdate();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "smartmonitor";
            webMetricsList.Columns.Add(header);
            webMetricsList.Items.Clear();
            webMetricsList.FullRowSelect = true;
            webMetricsList.Alignment = ListViewAlignment.Left;
            webMetricsList.MultiSelect = true;
            webMetricsList.Scrollable = true;
            webMetricsList.View = View.Details;
            webMetricsList.HeaderStyle = ColumnHeaderStyle.None;
            webMetricsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //List websites
            var websites = ResourceService.GetResourcesByType("Microsoft.Web/sites");
            foreach (var web in websites)
            {
                websiteChooser.Items.Add(web.name);
            }

            //List metric definitions
            var resourceIdApp = "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/smartMonitorDemoApp/providers/Microsoft.Web/sites/smartMonitorDemoApp";
            var metricDefinitions = MetricDefinitionService.GetMetricDefinitions(resourceIdApp);
            foreach (var metricDef in metricDefinitions)
            {
                var item = new ListViewItem(metricDef.name.localizedValue);
                item.Tag = metricDef.name.value;
                webMetricsList.Items.Add(item);
            }
            webMetricsList.EndUpdate();
        }

        private void webMetricsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (webMetricsList.SelectedItems.Count == 0)
                {
                    return;
                }

                if (websiteChooser.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Please select a website!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resourceURI = ResourceService.GetResourcesByType("Microsoft.Web/sites")
                    .Where(x => x.name == websiteChooser.SelectedItem.ToString())
                    .Select(x => x.id)
                    .FirstOrDefault();

                string metricNames = string.Empty;
                foreach (ListViewItem selectedMetricDefinition in webMetricsList.SelectedItems)
                {
                    metricNames += selectedMetricDefinition.Tag + ",";
                }
                metricNames = metricNames.Remove(metricNames.Length - 1);

                string interval = "PT1M";
                string timespan = $"{DateTime.UtcNow.AddMinutes(-5).ToString("s")}Z/{DateTime.UtcNow.ToString("s")}Z";
                string metricsUrl =
                    $"{Constants.ARMEndpoint}{resourceURI}{Constants.InsightsAPIURI}/metrics?timespan={timespan}&interval={interval}&metricnames={metricNames}&{Constants.ApiVersionURI}";
                var json = ApiCallsManager.PerformGet(metricsUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                MetricRootObject metrics = JsonConvert.DeserializeObject<MetricRootObject>(json);
                LoadWebsiteChart(metrics);
            }
            catch (System.Exception ex)
            {
                MetroMessageBox.Show(this, "Unexpected error", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWebsiteChart(MetricRootObject metrics)
        {
            websiteChart.AxisX.Clear();
            websiteChart.AxisY.Clear();

            switch (metrics.interval)
            {
                case "PT1M":
                    websiteChart.AxisX.Add(new Axis
                    {
                        Labels = new[]
                        {
                            System.DateTime.Now.AddMinutes(-4).ToString("t"),
                            System.DateTime.Now.AddMinutes(-3).ToString("t"),
                            System.DateTime.Now.AddMinutes(-2).ToString("t"),
                            System.DateTime.Now.AddMinutes(-1).ToString("t"),
                            System.DateTime.Now.ToString("t")
                        }
                    });
                    break;
            }

            websiteChart.Series = new SeriesCollection();

            foreach (var metric in metrics.value)
            {
                switch (metric.unit)
                {
                    case "Seconds":
                        var lineSeries = new LineSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            lineSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        websiteChart.Series.Add(lineSeries);
                        break;
                    case "Count":
                        var columnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.DodgerBlue,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            columnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        websiteChart.Series.Add(columnSeries);
                        break;
                    case "Bytes":
                        var bytesColumnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Chocolate,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            bytesColumnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        websiteChart.Series.Add(bytesColumnSeries);
                        break;
                    case "BytesPerSecond":
                        var bytesSColumnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Firebrick,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            bytesSColumnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        websiteChart.Series.Add(bytesSColumnSeries);
                        break;
                }
            }
        }

        #endregion

        #region VM
        private void LoadVirtualMachineTab()
        {
            //UI
            vmMetricsList.BeginUpdate();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "smartmonitor";
            vmMetricsList.Columns.Add(header);
            vmMetricsList.Items.Clear();
            vmMetricsList.FullRowSelect = true;
            vmMetricsList.Alignment = ListViewAlignment.Left;
            vmMetricsList.MultiSelect = true;
            vmMetricsList.Scrollable = true;
            vmMetricsList.View = View.Details;
            vmMetricsList.HeaderStyle = ColumnHeaderStyle.None;
            vmMetricsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //List vms
            var vms = ResourceService.GetResourcesByType("Microsoft.Compute/virtualMachines");
            foreach (var vm in vms)
            {
                vmChooser.Items.Add(vm.name);
            }

            //List metric definitions
            var resourceId =
                "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/SmartMonitorVM/providers/Microsoft.Compute/virtualMachines/VirtualMachineSM";
            var metricDefinitions = MetricDefinitionService.GetMetricDefinitions(resourceId);
            foreach (var metricDef in metricDefinitions)
            {
                var item = new ListViewItem(metricDef.name.localizedValue);
                item.Tag = metricDef.name.value;
                vmMetricsList.Items.Add(item);
            }
            vmMetricsList.EndUpdate();
        }
        private void vmMetricsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (vmMetricsList.SelectedItems.Count == 0)
                {
                    return;
                }

                if (vmChooser.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Please select a virtual machine!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string startDate = startVMTime.Text;
                string endDate = endVMTime.Text;
                if (string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
                {
                    MetroMessageBox.Show(this, "Please select a date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resourceURI = ResourceService.GetResourcesByType("Microsoft.Compute/virtualMachines")
                    .Where(x => x.name == vmChooser.SelectedItem.ToString())
                    .Select(x => x.id)
                    .FirstOrDefault();

                string metricNames = string.Empty;
                foreach (ListViewItem selectedMetricDefinition in vmMetricsList.SelectedItems)
                {
                    metricNames += selectedMetricDefinition.Tag + ",";
                }
                metricNames = metricNames.Remove(metricNames.Length - 1);

                DateTime startDateTime = DateTime.Parse(startDate).AddDays(-1);
                DateTime endDateTime = DateTime.Parse(endDate);
                string interval = "PT12H";
                string timespan = $"{startDateTime.ToString("s")}Z/{endDateTime.ToString("s")}Z";
                string metricsUrl =
                    $"{Constants.ARMEndpoint}{resourceURI}{Constants.InsightsAPIURI}/metrics?timespan={timespan}&interval={interval}&metricnames={metricNames}&{Constants.ApiVersionURI}";
                var json = ApiCallsManager.PerformGet(metricsUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                MetricRootObject metrics = JsonConvert.DeserializeObject<MetricRootObject>(json);
                LoadVmChart(metrics, startDateTime, endDateTime);
            }
            catch (System.Exception ex)
            {
                MetroMessageBox.Show(this, "Unexpected error", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVmChart(MetricRootObject metrics, DateTime startDate, DateTime endDate)
        {
            vmChart.AxisX.Clear();
            vmChart.AxisY.Clear();

            percentageCPUchart.Value = GetPercentageCPU();

            switch (metrics.interval)
            {
                case "PT12H":
                    var axis = new Axis() { Labels = new List<string>() };

                    for (DateTime date = startDate; date.Date <= endDate.Date; date = date.AddHours(12))
                    {
                        axis.Labels.Add(date.ToString("g"));
                    }
                    vmChart.AxisX.Add(axis);
                    break;
            }

            vmChart.Series = new SeriesCollection();

            foreach (var metric in metrics.value)
            {
                switch (metric.unit)
                {
                    case "Percent":
                        var cpSeries = new LineSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Fuchsia,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            cpSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        vmChart.Series.Add(cpSeries);
                        break;
                    case "CountPerSecond":
                        var ccSeries = new LineSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            ccSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        vmChart.Series.Add(ccSeries);
                        break;
                    case "Count":
                        var columnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Brown,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            columnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        vmChart.Series.Add(columnSeries);
                        break;
                    case "Bytes":
                        var bytesColumnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.ForestGreen,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            bytesColumnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        vmChart.Series.Add(bytesColumnSeries);
                        break;
                }
            }
        }

        public double GetPercentageCPU()
        {
            string resourceURI = ResourceService.GetResourcesByType("Microsoft.Compute/virtualMachines")
                .Where(x => x.name == vmChooser.SelectedItem.ToString())
                .Select(x => x.id)
                .FirstOrDefault();

            string metricsUrl =
                $"{Constants.ARMEndpoint}{resourceURI}{Constants.InsightsAPIURI}/metrics?metricnames=Percentage CPU&{Constants.ApiVersionURI}";
            var json = ApiCallsManager.PerformGet(metricsUrl);
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            MetricRootObject metrics = JsonConvert.DeserializeObject<MetricRootObject>(json);

            return metrics.value[metrics.value.Count-1].timeseries[0].data[metrics.value[metrics.value.Count-1].timeseries[0].data.Count-1].average;
        }

        private void startVMTime_ValueChanged(object sender, EventArgs e)
        {
            vmMetricsList_SelectedIndexChanged(sender, e);
        }

        private void endVMTime_ValueChanged(object sender, EventArgs e)
        {
            vmMetricsList_SelectedIndexChanged(sender, e);
        }

        private void vmChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            percentageCPUchart.Value = GetPercentageCPU();
        }

        #endregion

        #region StorageAccounts
        private void LoadStorageAccountsTab()
        {
            //UI
            storageMetricsList.BeginUpdate();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "smartmonitor";
            storageMetricsList.Columns.Add(header);
            storageMetricsList.Items.Clear();
            storageMetricsList.FullRowSelect = true;
            storageMetricsList.Alignment = ListViewAlignment.Left;
            storageMetricsList.MultiSelect = true;
            storageMetricsList.Scrollable = true;
            storageMetricsList.View = View.Details;
            storageMetricsList.HeaderStyle = ColumnHeaderStyle.None;
            storageMetricsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //List storage accounts
            var storageAccounts = ResourceService.GetResourcesByType("Microsoft.Storage/storageAccounts");
            foreach (var sa in storageAccounts)
            {
                storageAccountChooser.Items.Add(sa.name);
            }

            //List metric definitions
            var resourceIdApp = "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/smartmonitorSA/providers/Microsoft.Storage/storageAccounts/smstorage1";
            var metricDefinitions = MetricDefinitionService.GetMetricDefinitions(resourceIdApp);
            foreach (var metricDef in metricDefinitions)
            {
                var item = new ListViewItem(metricDef.name.localizedValue);
                item.Tag = metricDef.name.value;
                storageMetricsList.Items.Add(item);
            }
            storageMetricsList.EndUpdate();
        }

        private void storageMetricsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (storageMetricsList.SelectedItems.Count == 0)
                {
                    return;
                }

                if (storageAccountChooser.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Please select a storage account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string resourceURI = ResourceService.GetResourcesByType("Microsoft.Storage/storageAccounts")
                    .Where(x => x.name == storageAccountChooser.SelectedItem.ToString())
                    .Select(x => x.id)
                    .FirstOrDefault();

                string metricNames = string.Empty;
                foreach (ListViewItem selectedMetricDefinition in storageMetricsList.SelectedItems)
                {
                    metricNames += selectedMetricDefinition.Tag + ",";
                }
                metricNames = metricNames.Remove(metricNames.Length - 1);

                string interval = "PT1H";
                string timespan = $"{DateTime.Now.AddMinutes(-300).ToString("s")}Z/{DateTime.Now.ToString("s")}Z";
                string metricsUrl =
                    $"{Constants.ARMEndpoint}{resourceURI}{Constants.InsightsAPIURI}/metrics?interval={interval}&timespan={timespan}&metricnames={metricNames}&{Constants.ApiVersionURI}";
                var json = ApiCallsManager.PerformGet(metricsUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                MetricRootObject metrics = JsonConvert.DeserializeObject<MetricRootObject>(json);
                LoadStorageAccountsChart(metrics);
            }
            catch (System.Exception ex)
            {
                MetroMessageBox.Show(this, "Unexpected error", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStorageAccountsChart(MetricRootObject metrics)
        {
            storageChart.AxisX.Clear();
            storageChart.AxisY.Clear();

            switch (metrics.interval)
            {
                case "PT1H":
                    storageChart.AxisX.Add(new Axis
                    {
                        Labels = new[]
                        {
                            System.DateTime.Now.AddMinutes(-300).ToString("t"),
                            System.DateTime.Now.AddMinutes(-240).ToString("t"),
                            System.DateTime.Now.AddMinutes(-180).ToString("t"),
                            System.DateTime.Now.AddMinutes(-120).ToString("t"),
                            System.DateTime.Now.AddMinutes(-60).ToString("t"),
                            System.DateTime.Now.ToString("t")
                        }
                    });
                    break;
            }

            storageChart.Series = new SeriesCollection();

            foreach (var metric in metrics.value)
            {
                switch (metric.unit)
                {
                    case "Percent":
                        var lineSeries = new LineSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Transparent,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            lineSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        storageChart.Series.Add(lineSeries);
                        break;
                    case "Count":
                        var columnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.DodgerBlue,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            columnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        storageChart.Series.Add(columnSeries);
                        break;
                    case "Bytes":
                        var bytesColumnSeries = new ColumnSeries
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.Chocolate,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            bytesColumnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        storageChart.Series.Add(bytesColumnSeries);
                        break;
                    case "MilliSeconds":
                        var mlColumnSeries = new LineSeries()
                        {
                            Values = new ChartValues<double>(),
                            Fill = System.Windows.Media.Brushes.LightBlue,
                            Title = metric.name.localizedValue + " | " + metric.unit
                        };

                        foreach (var timeSeries in metric.timeseries[0].data)
                        {
                            mlColumnSeries.Values.Add(timeSeries.total == 0 ? timeSeries.average : timeSeries.total);
                        }

                        storageChart.Series.Add(mlColumnSeries);
                        break;
                }
            }
        }

        #endregion

        private void LoadOperations()
        {
            operationsList.View = View.Details;
            operationsList.Alignment = ListViewAlignment.SnapToGrid;
            operationsList.BeginUpdate();
            operationsList.Items.Clear();

            operationsList.Columns.Add("Name");
            operationsList.Columns.Add("Resource");
            operationsList.Columns.Add("Description");
            operationsList.MultiSelect = false;
            var url = "https://management.azure.com/providers/microsoft.insights/operations?api-version=2015-04-01";
            var result = ApiCallsManager.PerformGet(url);
            OperationsRootObject operations = JsonConvert.DeserializeObject<OperationsRootObject>(result);

            foreach (var operation in operations.value)
            {
                var item = new ListViewItem(new[] { operation.name, operation.display.resource, operation.display.description });
                operationsList.Items.Add(item);
                operationsList.Items[0].Checked = true;
            }

            operationsList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            operationsList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            operationsList.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            operationsList.EndUpdate();
            operationsList.AllowSorting = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.ShowDialog();
        }
    }
}
