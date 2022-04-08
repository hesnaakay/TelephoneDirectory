using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Web.Models.Contact;
using TelephoneDirectory.Web.Services;

namespace TelephoneDirectory.Web.Controllers
{
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly IUserService _userService;
        private readonly IContactService _contactService;
        public ContactController(IUserService userService, IContactService contactService)
        {
            _userService = userService;
            _contactService = contactService;
        }

        [HttpGet("AddContact")]
        public IActionResult AddContact(string id)
        {
            ViewData["userid"] = id;
            return View();
        }

        [HttpPost("AddContact")]
        public async Task<IActionResult> AddContact(ContactCreateInput contactCreateInput)
        {
            var responseCreateContact = await _contactService.CreateAsync(contactCreateInput);
            TempData["userid"] = responseCreateContact.UserId;
            return Redirect("/Contact/GetAllContact/" + responseCreateContact.UserId);
        }

        [HttpGet("GetAllContact/{userid}")]
        public async Task<IActionResult> GetAllContact(string userid)
        {
            var contactViewModel = await _contactService.GetAllByUserIdAsync(userid);
            return View(contactViewModel);
        }
        [HttpGet("RemoveContact/{contactid}/{userid}")]
        public async Task<IActionResult> RemoveContact(string contactid, string userid)
        {
            var responseCreateContact = await _contactService.DeleteAsync(contactid);
            return Redirect("/Contact/GetAllContact/" + userid);
        }
    }
}
