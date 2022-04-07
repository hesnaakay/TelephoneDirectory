using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TelephoneDirectory.Libraries.Core
{
    public class ContactDto
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        [BsonIgnore]
        public User User { get; set; }
    }
}
