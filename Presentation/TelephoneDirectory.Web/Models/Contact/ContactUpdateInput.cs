using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneDirectory.Web.Models.Contact
{
    public class ContactUpdateInput
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
