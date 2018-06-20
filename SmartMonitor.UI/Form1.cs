using System;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json;
using SmartMonitor.Business;
using SmartMonitor.Models.MetricDefinition;
using SmartMonitor.Models.Operations;
using SmartMonitor.UI.Extensions;
using System.Windows.Forms;

namespace SmartMonitor.UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private ApiCallsManager APIManager { get; set; }

        public Form1()
        {
            this.components = new System.ComponentModel.Container();
            InitializeComponent();
            this.components.SetStyle(this);
            this.components.SetDefaultTheme(this, MetroThemeStyle.Light);
            this.APIManager = new ApiCallsManager();
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            //Get ARM VM metrics via Monitor REST API
            var resourceId =
                "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/SmartMonitorVM/providers/Microsoft.Compute/virtualMachines/VirtualMachineSM";

            //string baseURL = armEndpoint + resourceId + "/providers/microsoft.insights/metricdefinitions?api-version="+apiVersionURI;
            //string result = PerformGet(baseURL, GetAccessTokenAsync().Result);
            //dynamic parsedJson = JsonConvert.DeserializeObject(result);
            //string arranged = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            //Console.WriteLine(arranged);

            //Get classic VM metrics via Insights REST API


            //Get WebApp metrics via Insights REST API
            //website metric definition url
            var armEndpoint = "https://management.azure.com";
            var resourceIdApp = "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/smartMonitorDemoApp/providers/Microsoft.Web/sites/smartMonitorDemoApp";
            var insightsAPIURI = "/providers/microsoft.insights";
            var metricDefinitionsURI = "/metricdefinitions";
            var apiVersionURI = "?api-version=2018-01-01";
            string baseURL = $"{armEndpoint}{resourceIdApp}{insightsAPIURI}{metricDefinitionsURI}{apiVersionURI}";


            string result = null;
            try
            {
                result = APIManager.PerformGet($"https://management.azure.com/{resourceIdApp}/providers/microsoft.insights/metrics?api-version=2018-01-01");
                dynamic parsedJson = JsonConvert.DeserializeObject(result);
                string arranged = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MetricDefinitionRootObject metricDefinitionsWebsite = JsonConvert.DeserializeObject<MetricDefinitionRootObject>(result);
            int count = metricDefinitionsWebsite.value.Count;
        }

        private void LoadOperations()
        {
            operationsList.View = View.Details;
            operationsList.Alignment = ListViewAlignment.SnapToGrid;
            operationsList.BeginUpdate();
            operationsList.Items.Clear();

            operationsList.Columns.Add("Name", 400);
            operationsList.Columns.Add("Resource", 193);
            operationsList.Columns.Add("Description", 345);
            operationsList.MultiSelect = false;
            var url = "https://management.azure.com/providers/microsoft.insights/operations?api-version=2015-04-01";
            var result = APIManager.PerformGet(url);
            OperationsRootObject operations = JsonConvert.DeserializeObject<OperationsRootObject>(result);

            foreach (var operation in operations.value)
            {
                var item = new ListViewItem(new[] {operation.name, operation.display.resource, operation.display.description});
                operationsList.Items.Add(item);
                operationsList.Items[0].Checked = true;
            }

            operationsList.EndUpdate();
            operationsList.AllowSorting = true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadOperations();
            LoadWebsiteChart();
        }

        private void LoadWebsiteChart()
        {
            //websiteChart.AnimationsSpeed = TimeSpan.FromSeconds(1);
            //websiteChart.AxisX = 
        }
    }
}
