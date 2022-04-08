using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models
{
    public class ServiceApiSettings
    {
        public string GatewayBaseUri { get; set; }
        public ServiceApi Book { get; set; }
        public ServiceApi Report { get; set; }
    }
    public class ServiceApi
    {
        public string Path { get; set; }
    }
}
