using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Web.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllAsync();
        Task<UserDto> CreateAsync(UserDto UserDto);
        Task<UserDto> GetByIdAsync(string id);
        Task<NoContent> DeleteAsync(string id);

    }
}
