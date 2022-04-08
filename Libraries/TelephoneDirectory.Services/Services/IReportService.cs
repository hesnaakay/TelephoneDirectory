using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Libraries.Services
{
    public interface IReportService
    {
        Task<Response<List<ReportDto>>> GetAllAsync();
        Task<Response<ReportCollection>> GetByIdAsync(string id);
        Task<Response<ReportDto>> GetByLocationAsync(string location);
        Task<Response<ReportDto>> CreateAsync(ReportCreateDto ReportCreateDto);
        Task<Response<NoContent>> UpdateAsync(ReportDto ReportCreateDto);
        Task<Response<NoContent>> UpdateAsync(ReportCollection ReportCreateDto);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
