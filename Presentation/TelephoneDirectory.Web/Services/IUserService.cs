using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.User;

namespace TelephoneDirectory.Web.Services
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
        Task<UserViewModel> CreateAsync(UserCreateInput userCreateInput);
        Task<UserViewModel> GetByIdAsync(string id);
        Task<bool> DeleteAsync(string id);

    }
}
