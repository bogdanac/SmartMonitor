using System;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json;
using SmartMonitor.Business;
using SmartMonitor.Models.MetricDefinition;
using SmartMonitor.Models.Operations;
using SmartMonitor.UI.Extensions;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace SmartMonitor.UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MetricDefinitionService MetricDefinitionService { get; set; }

        public Form1()
        {
            MetricDefinitionService = new MetricDefinitionService();
            this.components = new System.ComponentModel.Container();
            InitializeComponent();
            this.components.SetStyle(this);
            this.components.SetDefaultTheme(this, MetroThemeStyle.Light);
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            //Get classic VM metrics via Insights REST API

            //string metricnames = "AverageResponseTime";
            //string metricsUrl =
            //    $"https://management.azure.com/{resourceURI}/providers/microsoft.insights/metrics?timespan=2018-06-19T02:20:00Z/2018-06-20T14:20:00Z&interval=PT1H&metricnames={metricnames}&api-version=2018-01-01";
            //result = ApiCallsManager.PerformGet(metricsUrl);
        }

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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadOperations();
            LoadWebsiteTab();
            LoadVirtualMachineTab();
        }

        private void LoadWebsiteTab()
        {
            websiteChooser.Items.Add("SmartMonitorDemoApp");


            webMetricsList.BeginUpdate();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "";
            webMetricsList.Columns.Add(header);
            webMetricsList.Items.Clear();
            webMetricsList.FullRowSelect = true;
            webMetricsList.Alignment = ListViewAlignment.Left;
            webMetricsList.MultiSelect = true;
            webMetricsList.Scrollable = true;
            vmMetricsList.View = View.Details;
            vmMetricsList.HeaderStyle = ColumnHeaderStyle.None;

            var resourceIdApp = "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/smartMonitorDemoApp/providers/Microsoft.Web/sites/smartMonitorDemoApp";
            var metricDefinitions = MetricDefinitionService.GetMetricDefinitions(resourceIdApp);
            foreach (var metricDef in metricDefinitions)
            {
                webMetricsList.Items.Add(metricDef.name.localizedValue);
            }
            webMetricsList.EndUpdate();

            LoadWebsiteChart();
        }

        private void LoadVirtualMachineTab()
        {
            vmChooser.Items.Add("SmartMonitorVM");

            vmMetricsList.BeginUpdate();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "";
            vmMetricsList.Columns.Add(header);
            vmMetricsList.Items.Clear();
            vmMetricsList.FullRowSelect = true;
            vmMetricsList.Alignment = ListViewAlignment.Left;
            vmMetricsList.MultiSelect = true;
            vmMetricsList.Scrollable = true;
            vmMetricsList.View = View.List;
            vmMetricsList.HeaderStyle = ColumnHeaderStyle.None;

            var resourceId =
                "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/SmartMonitorVM/providers/Microsoft.Compute/virtualMachines/VirtualMachineSM";
            var metricDefinitions = MetricDefinitionService.GetMetricDefinitions(resourceId);
            foreach (var metricDef in metricDefinitions)
            {
                vmMetricsList.Items.Add(metricDef.name.localizedValue);
            }
            vmMetricsList.EndUpdate();
            //string baseURL = armEndpoint + resourceId + "/providers/microsoft.insights/metricdefinitions?api-version="+apiVersionURI;
            //string result = PerformGet(baseURL, GetAccessTokenAsync().Result);
            //dynamic parsedJson = JsonConvert.DeserializeObject(result);
            //string arranged = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            //Console.WriteLine(arranged);
        }

        private void LoadWebsiteChart()
        {
            websiteChart.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    System.DateTime.Now.ToString("hh:mm:ss t z"),
                    System.DateTime.Now.AddMinutes(1).ToString("hh:mm:ss t z"),
                    System.DateTime.Now.AddMinutes(2).ToString("hh:mm:ss t z"),
                    System.DateTime.Now.AddMinutes(3).ToString("hh:mm:ss t z"),
                    System.DateTime.Now.AddMinutes(4).ToString("hh:mm:ss t z")
                }
            });

            websiteChart.Series = new SeriesCollection
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
    }
}
