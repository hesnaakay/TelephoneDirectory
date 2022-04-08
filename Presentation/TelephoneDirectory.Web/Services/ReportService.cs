using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Web.Models.Report;

namespace TelephoneDirectory.Web.Services
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _client;

        public ReportService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<ReportViewModel>> GetAllAsync()
        {
            var response = await _client.GetAsync("reports");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<ReportViewModel>>>();

            return responseSuccess.Data;
        }
        public async Task<ReportViewModel> GetByIdAsync(string id)
        {
            var response = await _client.GetAsync($"reports/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<ReportViewModel>>();

            return responseSuccess.Data;
        }
        public async Task<ReportViewModel> CreateAsync(ReportCreateInput reportCreateInput)
        {
            var response = await _client.PostAsJsonAsync<ReportCreateInput>("reports", reportCreateInput);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<ReportViewModel>>();

            return responseSuccess.Data;
        }

        public async Task<bool> UpdateAsync(ReportUpdateInput reportUpdateInput)
        {
            var response = await _client.PutAsJsonAsync<ReportUpdateInput>("reports", reportUpdateInput);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _client.DeleteAsync($"reports/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<List<ReportViewModel>> GetByLocationAsync(string location)
        {
            var response = await _client.GetAsync($"reports/GetByLocationAsync/{location}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<ReportViewModel>>>();

            return responseSuccess.Data;
        }
    }
}
