using AutoMapper;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.User;

namespace TelephoneDirectory.Web.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<UserViewModel>> GetAllAsync()
        {
            var response = await _client.GetAsync("users");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<UserViewModel>>>();

            return responseSuccess.Data;
        }
        public async Task<UserViewModel> CreateAsync(UserCreateInput userCreateInput)
        {
            var response = await _client.PostAsJsonAsync<UserCreateInput>("users", userCreateInput);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<UserViewModel>>();

            return responseSuccess.Data;
        }

        public async Task<UserViewModel> GetByIdAsync(string id)
        {
            var response = await _client.GetAsync($"users/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<UserViewModel>>();

            return responseSuccess.Data;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _client.DeleteAsync($"users/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
