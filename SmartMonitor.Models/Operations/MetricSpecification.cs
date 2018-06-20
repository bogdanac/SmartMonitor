using System.Collections.Generic;

namespace SmartMonitor.Models.Operations
{
    public class MetricSpecification
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string internalMetricName { get; set; }
        public string displayDescription { get; set; }
        public string unit { get; set; }
        public string aggregationType { get; set; }
        public object availabilities { get; set; }
        public bool fillGapWithZero { get; set; }
        public string category { get; set; }
        public IList<OperationDimension> dimensions { get; set; }
        public IList<string> supportedAggregationTypes { get; set; }
    }
}