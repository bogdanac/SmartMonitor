using System.Collections.Generic;

namespace SmartMonitor.Models.Operations
{
    public class ServiceSpecification
    {
        public IList<MetricSpecification> metricSpecifications { get; set; }
        public object logSpecifications { get; set; }
        public object legacyMetricSpecifications { get; set; }
    }
}