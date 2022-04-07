using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : CustomBaseController
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _contactService.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        //contacts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _contactService.GetByIdAsync(id);

            return CreateActionResultInstance(response);
        }

        [HttpGet]
        [Route("/api/[controller]/GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _contactService.GetAllByUserIdAsync(userId);

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactCreateDto ContactDto)
        {
            var response = await _contactService.CreateAsync(ContactDto);

            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ContactDto ContactDto)
        {
            var response = await _contactService.UpdateAsync(ContactDto);

            return CreateActionResultInstance(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _contactService.DeleteAsync(id);

            return CreateActionResultInstance(response);
        }
    }
}
