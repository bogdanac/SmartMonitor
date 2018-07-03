using System.Collections.Generic;

namespace SmartMonitor.Models.Metrics
{
    public class Timesery
    {
        public IList<object> metadatavalues { get; set; }
        public IList<Datum> data { get; set; }
    }
}
