using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Web.Models.Report;

namespace TelephoneDirectory.Web.Services
{
    public interface IReportService
    {
        Task<List<ReportViewModel>> GetAllAsync();
        Task<ReportViewModel> GetByIdAsync(string id);
        Task<List<ReportViewModel>> GetByLocationAsync(string location);
        Task<ReportViewModel> CreateAsync(ReportCreateInput reportCreateInput);
        Task<bool> UpdateAsync(ReportUpdateInput reportUpdateInput);
        Task<bool> DeleteAsync(string id);
    }
}
