using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Libraries.Core
{
    public class HomeDto
    {
        public List<UserDto> userList { get; set; }
        public List<ReportDto> reportList { get; set; }
        public List<ContactDto> contactList { get; set; }
      
    }
}
