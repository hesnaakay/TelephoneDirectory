using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Web.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(UserDto userDto)
        {
            var responseCreateReport = await _userService.CreateAsync(userDto);
            return RedirectToAction("Index", "Home", "");
        }
        [HttpGet("RemoveUser/{userid}")]
        public async Task<IActionResult> RemoveUser(string UserId)
        {
            var responseCreateContact = await _userService.DeleteAsync(UserId);
            return Redirect("/Home/Index");
        }

    }
}
