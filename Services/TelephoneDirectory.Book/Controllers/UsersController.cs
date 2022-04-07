using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : CustomBaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _userService.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        //users/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _userService.GetByIdAsync(id);

            return CreateActionResultInstance(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            var response = await _userService.CreateAsync(userDto);

            return CreateActionResultInstance(response);
        }

       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _userService.DeleteAsync(id);

            return CreateActionResultInstance(response);
        }
    }
}
