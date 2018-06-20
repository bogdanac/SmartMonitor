using System.Collections.Generic;

namespace SmartMonitor.Models.Operations
{
    public class OperationDimension
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public bool toBeExportedForShoebox { get; set; }
        public bool isHidden { get; set; }
        public IList<DefaultDimensionValue> defaultDimensionValues { get; set; }
    }
}