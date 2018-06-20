using System.Collections.Generic;

namespace SmartMonitor.Models.MetricDefinition
{
    public class MetricDefinition
    {
        public string id { get; set; }
        public string resourceId { get; set; }
        public string @namespace { get; set; }
        public MetricDefinitionName name { get; set; }
        public bool isDimensionRequired { get; set; }
        public string unit { get; set; }
        public string primaryAggregationType { get; set; }
        public List<string> supportedAggregationTypes { get; set; }
        public List<MetricAvailability> metricAvailabilities { get; set; }
        public List<Dimension> dimensions { get; set; }
    }
}
