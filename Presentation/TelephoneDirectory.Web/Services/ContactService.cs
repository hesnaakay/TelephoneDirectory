using MongoDB.Driver;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.Contact;

namespace TelephoneDirectory.Web.Services
{
    public class ContactService:IContactService
    {
        private readonly HttpClient _client;

        public ContactService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ContactDto>> GetAllAsync()
        {
            var response = await _client.GetAsync("contacts");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<ContactDto>>>();

            return responseSuccess.Data;
        }
        //public async Task<List<ContactViewModel>> GetByIdAsync(string id)
        //{
        //    var response = await _client.GetAsync($"contacts/GetByIdAsync/{id}");
        //    if (!response.IsSuccessStatusCode)
        //    {
        //        return null;
        //    }

        //    var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<ContactViewModel>>>();

        //    return responseSuccess.Data;
        //}
        //public async Task<List<ContactDto>> GetAllByUserIdAsync(string userId)
        //{
        //    var response = await _client.GetAsync($"contacts/GetAllByUserIdAsync/{userId}");
        //    if (!response.IsSuccessStatusCode)
        //    {
        //        return null;
        //    }

        //    var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<ContactDto>>>();

        //    return responseSuccess.Data;
        //}

        //public async Task<bool> CreateAsync(ContactCreateInput contactCreateInput)
        //{
        //    var response = await _client.PostAsJsonAsync<ContactCreateInput>("contacts", contactCreateInput);

        //    return response.IsSuccessStatusCode;
        //}

        //public async Task<bool> UpdateAsync(ContactUpdateInput contactUpdateInput)
        //{
        //    var response = await _client.PutAsJsonAsync<ContactUpdateInput>("contacts", contactUpdateInput);

        //    return response.IsSuccessStatusCode;
        //}

        //public async Task<bool> DeleteAsync(string id)
        //{
        //    var response = await _client.DeleteAsync($"contacts/{id}");

        //    return response.IsSuccessStatusCode;
        //}
        //public async Task<List<Contact>> GetAllByLocationAsync(string location)
        //{
        //    var response = await _client.GetAsync($"contacts/GetAllByLocationAsync/{location}");
        //    if (!response.IsSuccessStatusCode)
        //    {
        //        return null;
        //    }

        //    var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<Contact>>>();

        //    return responseSuccess.Data;
        //}
    }
}
