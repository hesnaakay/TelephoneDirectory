namespace TelephoneDirectory.Libraries.Data
{
    public interface IDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ReportCollectionName { get; set; }
        public string ContactCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
