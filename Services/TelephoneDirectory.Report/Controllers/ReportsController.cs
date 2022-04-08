using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : CustomBaseController
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _reportService.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        //reports/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _reportService.GetByIdAsync(id);

            return CreateActionResultInstance(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create(ReportCreateDto reportCreateDto)
        {
            var response = await _reportService.CreateAsync(reportCreateDto);

            return CreateActionResultInstance(response);
        }

       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _reportService.DeleteAsync(id);

            return CreateActionResultInstance(response);
        }
    }
}
