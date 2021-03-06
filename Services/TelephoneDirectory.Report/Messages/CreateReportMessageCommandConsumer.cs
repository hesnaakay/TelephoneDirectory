using MassTransit;
using MongoDB.Driver;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;

namespace TelephoneDirectory.Report.Messages
{
    public class CreateReportMessageCommandConsumer : IConsumer<CreateReportMessageCommand>
    {
        private readonly IReportService _reportService;
        private readonly IContactService _contactService;

        public CreateReportMessageCommandConsumer(IReportService reportService, IContactService contactService)
        {
            _reportService = reportService;
            _contactService = contactService;
        }

        public async Task Consume(ConsumeContext<CreateReportMessageCommand> context)
        {
            var contact = await _contactService.GetAllByLocationAsync(context.Message.Location);
            var reportDto = await _reportService.GetByIdAsync(context.Message.ReportId);
            reportDto.Data.TotalPhone = contact.Data.Count;
            reportDto.Data.TotalUser = contact.Data.Select(x => x.UserId).Distinct().Count();
            reportDto.Data.Location = context.Message.Location;
            reportDto.Data.ReportStatus = true;
            await _reportService.UpdateAsync(reportDto.Data);
        }
    }
}
