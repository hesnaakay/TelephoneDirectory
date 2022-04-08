using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.Contact;

namespace TelephoneDirectory.Web.Services
{
    public interface IContactService
    {
        Task<List<ContactDto>> GetAllAsync();
        //Task<List<ContactDto>> GetByIdAsync(string id);
        //Task<List<ContactViewModel>> GetAllByUserIdAsync(string userId);
        //Task<bool> CreateAsync(ContactCreateInput contactCreateInput);
        //Task<bool> UpdateAsync(ContactDto ContactUpdateDto);
        //Task<List<Contact>> GetAllByLocationAsync(string location);
        //Task<bool> DeleteAsync(string id);
    }
}
