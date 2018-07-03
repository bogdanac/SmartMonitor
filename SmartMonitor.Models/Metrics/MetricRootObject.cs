using Newtonsoft.Json;
using System.Collections.Generic;

namespace SmartMonitor.Models.Metrics
{
    public class MetricRootObject
    {
        public int cost { get; set; }
        public string timespan { get; set; }
        public string interval { get; set; }
        public IList<MetricValue> value { get; set; }
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        public string resourceregion { get; set; }
    }
}