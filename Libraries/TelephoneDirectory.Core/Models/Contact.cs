using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TelephoneDirectory.Libraries.Core
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string UserId { get; set; }


    }
}
