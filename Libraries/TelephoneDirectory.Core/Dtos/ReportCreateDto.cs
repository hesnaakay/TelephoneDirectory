using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TelephoneDirectory.Libraries.Core
{
    public class ReportCreateDto
    {
        public string Id { get; set; }
        public int TotalUser { get; set; }
        public int TotalPhone { get; set; }
        public string Location { get; set; }
        public DateTime RequestTime { get; set; } = DateTime.Now;
        public bool ReportStatus { get; set; } = false;
        public bool Deleted { get; set; } = false;

    }
}
