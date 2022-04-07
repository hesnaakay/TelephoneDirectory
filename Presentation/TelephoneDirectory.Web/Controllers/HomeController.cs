using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Dtos;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReportService _reportService;
        private readonly IUserService _userService;
        private readonly IContactService _contactService;
        private readonly ISendEndpointProvider _sendEndpointProvider;
        public HomeController(IReportService reportService, ISendEndpointProvider sendEndpointProvider, IUserService userService, IContactService contactService)
        {
            _reportService = reportService;
            _sendEndpointProvider = sendEndpointProvider;
            _userService = userService;
            _contactService = contactService;
        }


        public async Task<IActionResult> Index()
        {
           var userData = await _userService.GetAllAsync();
           var reportData = await _reportService.GetAllAsync();
           var contactData = await _contactService.GetAllAsync();
            HomeDto homeDto = new HomeDto
            {
                reportList = reportData.Data,
                userList = userData.Data,
                contactList = contactData.Data,
            };
            return View(homeDto);
        }


        public async Task<IActionResult> CreateReport(HomeMessagePostDto homeMessagePostDto)
        {
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:create-report-service"));
            ReportCreateDto reportCreateDto = new ReportCreateDto
            {
                Location = homeMessagePostDto.location,
                ReportStatus = false,
                RequestTime = DateTime.Now,
                TotalPhone = 0,
                TotalUser = 0,
                Deleted = false,
            };

            var responseCreateReport = await _reportService.CreateAsync(reportCreateDto);

            CreateReportMessageCommand report = new CreateReportMessageCommand();
            report.Location = responseCreateReport.Data.Location;
            report.ReportId = responseCreateReport.Data.Id;
            await sendEndpoint.Send<CreateReportMessageCommand>(report);

            return RedirectToAction("Index");
        }

    }
}
