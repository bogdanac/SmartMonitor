using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartMonitor.Models.MetricDefinition;
using Formatting = System.Xml.Formatting;

namespace SmartMonitor.Business
{
    public class MetricDefinitionService
    {
        public List<MetricDefinition> GetMetricDefinitions(string resourceURI)
        {
            var armEndpoint = "https://management.azure.com";
            var insightsAPIURI = "/providers/microsoft.insights";
            var metricDefinitionsURI = "/metricdefinitions";
            var apiVersionURI = "?api-version=2018-01-01";
            string baseURL = $"{armEndpoint}{resourceURI}{insightsAPIURI}{metricDefinitionsURI}{apiVersionURI}";

            string result = null;
            try
            {
                result = ApiCallsManager.PerformGet(baseURL);
            }
            catch (Exception)
            {
                return null;
            }

            MetricDefinitionRootObject metricDefinitions = JsonConvert.DeserializeObject<MetricDefinitionRootObject>(result);
            return metricDefinitions.value;
        }
    }
}
