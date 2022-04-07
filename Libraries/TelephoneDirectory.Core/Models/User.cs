using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace TelephoneDirectory.Libraries.Core
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }
}
