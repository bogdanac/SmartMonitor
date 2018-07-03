namespace SmartMonitor.Models.Resources
{
    public class ResourceDetails
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public Sku sku { get; set; }
        public string kind { get; set; }
        public string location { get; set; }
        public Tags tags { get; set; }
    }
}
