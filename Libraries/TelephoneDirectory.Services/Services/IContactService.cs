using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Libraries.Services
{
    public interface IContactService
    {
        Task<Response<List<ContactDto>>> GetAllAsync();
        Task<Response<ContactDto>> GetByIdAsync(string id);
        Task<Response<List<ContactDto>>> GetAllByUserIdAsync(string userId);
        Task<Response<ContactDto>> CreateAsync(ContactCreateDto ContactCreateDto);
        Task<Response<NoContent>> UpdateAsync(ContactDto ContactUpdateDto);
        Task<Response<NoContent>> DeleteAsync(string id);
        Task<Response<List<Contact>>> GetAllByLocationAsync(string location);
    }
}
