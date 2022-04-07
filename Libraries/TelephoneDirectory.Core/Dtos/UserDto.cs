using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace TelephoneDirectory.Libraries.Core
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }
}
