using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.Contact;

namespace TelephoneDirectory.Web.Services
{
    public interface IContactService
    {
        Task<List<ContactViewModel>> GetAllAsync();
        Task<List<ContactViewModel>> GetByIdAsync(string id);
        Task<List<ContactViewModel>> GetAllByUserIdAsync(string userId);
        Task<ContactViewModel> CreateAsync(ContactCreateInput contactCreateInput);
        Task<bool> UpdateAsync(ContactUpdateInput ContactUpdateDto);
        Task<bool> DeleteAsync(string id);
        Task<List<ContactViewModel>> GetAllByLocationAsync(string location);
    }
}
