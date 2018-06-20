using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartMonitor.Models.MetricDefinition
{
    public class MetricDefinitionRootObject
    {
        public List<MetricDefinition> value { get; set; }
    }
}
