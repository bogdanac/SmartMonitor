using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MetroFramework;
using Newtonsoft.Json;
using SmartMonitor.Business;
using SmartMonitor.Models.Metrics;
using SmartMonitor.Models.Operations;
using SmartMonitor.UI.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartMonitor.UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MetricDefinitionService MetricDefinitionService { get; set; }
        private ResourceService ResourceService { get; set; }

        public Form1()
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
                            System.DateTime.Now.AddMinutes(-4).ToString("g"),
                            System.DateTime.Now.AddMinutes(-3).ToString("g"),
                            System.DateTime.Now.AddMinutes(-2).ToString("g"),
                            System.DateTime.Now.AddMinutes(-1).ToString("g"),
                            System.DateTime.Now.ToString("g")
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
                            lineSeries.Values.Add(timeSeries.total);
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
                            columnSeries.Values.Add(timeSeries.total);
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
                            bytesColumnSeries.Values.Add(timeSeries.total);
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
                            bytesSColumnSeries.Values.Add(timeSeries.total);
                        }

                        websiteChart.Series.Add(bytesSColumnSeries);
                        break;
                }
            }
            //websiteChart.Series = new SeriesCollection
            //{
            //    new OhlcSeries
            //    {
            //        Values = new ChartValues<OhlcPoint>
            //        {
            //            new OhlcPoint(32, 35, 30, 32),
            //            new OhlcPoint(33, 38, 31, 37),
            //            new OhlcPoint(35, 42, 30, 40),
            //            new OhlcPoint(37, 40, 35, 38),
            //            new OhlcPoint(35, 38, 32, 33)
            //        }
            //    },
            //    new LineSeries
            //    {
            //        Values = new ChartValues<double> {30, 32, 35, 30, 28},
            //        Fill = System.Windows.Media.Brushes.Transparent,
            //        Title = "CPuTimeInSeconds"
            //    }
            //};
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
                vmMetricsList.Items.Add(metricDef.name.localizedValue);
            }
            vmMetricsList.EndUpdate();
        }


        

        private void LoadVmChart()
        {
            vmChart.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    System.DateTime.Now.ToString("dd MMM"),
                    System.DateTime.Now.AddMinutes(1).ToString("dd MMM"),
                    System.DateTime.Now.AddMinutes(2).ToString("dd MMM"),
                    System.DateTime.Now.AddMinutes(3).ToString("dd MMM"),
                    System.DateTime.Now.AddMinutes(4).ToString("dd MMM")
                }
            });

            vmChart.Series = new SeriesCollection
            {
                new OhlcSeries
                {
                    Values = new ChartValues<OhlcPoint>
                    {
                        new OhlcPoint(32, 35, 30, 32),
                        new OhlcPoint(33, 38, 31, 37),
                        new OhlcPoint(35, 42, 30, 40),
                        new OhlcPoint(37, 40, 35, 38),
                        new OhlcPoint(35, 38, 32, 33)
                    }
                },
                new LineSeries
                {
                    Values = new ChartValues<double> {30, 32, 35, 30, 28},
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };
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

        
    }
}
