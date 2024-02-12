namespace Home.Portal
{
    public class HomeOptions
    {
        public PageOptions FactStore { get; set; }
        public PageOptions DataCatalog { get; set; }
        public PageOptions SupplierForm { get; set; }
        public PageOptions ContextBroker { get; set; }
        public PageOptions Platform { get; set; }
        public PageOptions DataLake { get; set; }
        public PageOptions NiFi { get; set; }
        public PageOptions BackgroundJobs { get; set; }
    }

    public class PageOptions
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
