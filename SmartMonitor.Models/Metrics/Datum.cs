using System;

namespace SmartMonitor.Models.Metrics
{
    public class Datum
    {
        public DateTime timeStamp { get; set; }
        public double total { get; set; }
        public double count { get; set; }
        public double average { get; set; }
    }
}
