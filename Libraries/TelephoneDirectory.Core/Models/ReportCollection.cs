using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneDirectory.Libraries.Core
{
    public class ReportCollection
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int TotalUser { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int TotalPhone { get; set; }
        public string Location { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime RequestTime { get; set; } = DateTime.Now;
        [BsonRepresentation(MongoDB.Bson.BsonType.Boolean)]
        public bool ReportStatus { get; set; } = false;
        [BsonRepresentation(MongoDB.Bson.BsonType.Boolean)]
        public bool Deleted { get; set; } = false;
    }
}
