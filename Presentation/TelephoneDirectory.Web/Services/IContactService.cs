using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Web.Models.Contact;

namespace TelephoneDirectory.Web.Services
{
    public interface IContactService
    {
        Task<List<ContactViewModel>> GetAllAsync();
        Task<ContactViewModel> GetByIdAsync(string id);
        Task<List<ContactViewModel>> GetAllByUserIdAsync(string userId);
        Task<ContactViewModel> CreateAsync(ContactCreateInput contactCreateInput);
        Task<bool> UpdateAsync(ContactUpdateInput contactUpdateInput);
        Task<bool> DeleteAsync(string id);
        Task<List<ContactViewModel>> GetAllByLocationAsync(string location);
    }
}
