using Newtonsoft.Json;
using SmartMonitor.Models.MetricDefinition;
using System;
using System.Collections.Generic;

namespace SmartMonitor.Business
{
    public class MetricDefinitionService
    {
        public List<MetricDefinition> GetMetricDefinitions(string resourceURI)
        {
            string baseURL = $"{Constants.ARMEndpoint}{resourceURI}{Constants.InsightsAPIURI}/metricdefinitions?{Constants.ApiVersionURI}";

            string result = null;
            try
            {
                result = ApiCallsManager.PerformGet(baseURL);
                dynamic parsedJson = JsonConvert.DeserializeObject(result);
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
