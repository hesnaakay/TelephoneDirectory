using System.Collections.Generic;
using TelephoneDirectory.Web.Models.Contact;
using TelephoneDirectory.Web.Models.Report;
using TelephoneDirectory.Web.Models.User;

namespace TelephoneDirectory.Web.Models
{
    public class HomeViewModel
    {
        public List<ContactViewModel> contactList{ get; set; }=new List<ContactViewModel>();
        public List<ReportViewModel> reportList { get; set; } = new List<ReportViewModel>();    
        public List<UserViewModel> userList{ get; set; } = new List<UserViewModel>();   
    }
}
