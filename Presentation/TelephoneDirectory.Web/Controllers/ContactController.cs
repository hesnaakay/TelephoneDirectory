using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

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
        public async Task<IActionResult> AddContact(ContactCreateDto contactCreateDto)
        {
            var responseCreateContact = await _contactService.CreateAsync(contactCreateDto);
            TempData["userid"] = responseCreateContact.Data.UserId;
            return Redirect("/Contact/GetAllContact/" + responseCreateContact.Data.UserId);
        }
     
        [HttpGet("GetAllContact/{userid}")]
        public async Task<IActionResult> GetAllContact(string userid)
        {
            var contactData = await _contactService.GetAllByUserIdAsync(userid);
            HomeDto homeDto = new HomeDto
            {
                contactList = contactData.Data
            };
            return View(homeDto);
        }
        [HttpGet("RemoveContact/{contactid}/{userid}")]
        public async Task<IActionResult> RemoveContact(string contactid, string userid)
        {
            var responseCreateContact = await _contactService.DeleteAsync(contactid);
            return Redirect("/Contact/GetAllContact/" + userid);
        }
    }
}
