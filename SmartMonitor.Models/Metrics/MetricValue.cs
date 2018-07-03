using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMonitor.Models.MetricDefinition;

namespace SmartMonitor.Models.Metrics
{
    public class MetricValue
    {
        public string id { get; set; }
        public string type { get; set; }
        public MetricDefinitionName name { get; set; }
        public string unit { get; set; }
        public IList<Timesery> timeseries { get; set; }
    }
}
