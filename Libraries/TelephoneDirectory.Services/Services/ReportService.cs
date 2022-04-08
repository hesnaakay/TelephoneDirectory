using AutoMapper;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Data;

namespace TelephoneDirectory.Libraries.Services
{
    public class ReportService : IReportService
    {
        private readonly IMongoCollection<ReportCollection> _reportCollection;
        private readonly IMapper _mapper;

        public ReportService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);

            var database = client.GetDatabase(databaseSettings.DatabaseName);

            _reportCollection = database.GetCollection<ReportCollection>(databaseSettings.ReportCollectionName);
            _mapper = mapper;
        }
        public async Task<Response<List<ReportDto>>> GetAllAsync()
        {
            var contacts = await _reportCollection.Find(contact => true).ToListAsync();

            return Response<List<ReportDto>>.Success(_mapper.Map<List<ReportDto>>(contacts), 200);
        }
        public async Task<Response<ReportCollection>> GetByIdAsync(string id)
        {
            var contact = await _reportCollection.Find<ReportCollection>(x => x.Id == id).FirstOrDefaultAsync();

            return Response<ReportCollection>.Success(_mapper.Map<ReportCollection>(contact), 200);
        }
        public async Task<Response<ReportDto>> CreateAsync(ReportCreateDto ContactCreateDto)
        {
            var newContact = _mapper.Map<ReportCollection>(ContactCreateDto);

            await _reportCollection.InsertOneAsync(newContact);

            return Response<ReportDto>.Success(_mapper.Map<ReportDto>(newContact), 200);
        }

        public async Task<Response<NoContent>> UpdateAsync(ReportDto ReportUpdateDto)
        {
            var updateReport = _mapper.Map<ReportCollection>(ReportUpdateDto);

            var result = await _reportCollection.FindOneAndReplaceAsync(x => x.Id == ReportUpdateDto.Id, updateReport);

            if (result == null)
            {
                return Response<NoContent>.Fail("Report not found", 404);
            }

            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> UpdateAsync(ReportCollection ReportUpdateDto)
        {
            var result = await _reportCollection.FindOneAndReplaceAsync(x => x.Id == ReportUpdateDto.Id, ReportUpdateDto);

            if (result == null)
            {
                return Response<NoContent>.Fail("Report not found", 404);
            }

            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> DeleteAsync(string id)
        {
            var result = await _reportCollection.DeleteOneAsync(x => x.Id == id);

            if (result.DeletedCount > 0)
            {
                return Response<NoContent>.Success(204);
            }
            else
            {
                return Response<NoContent>.Fail("report not found", 404);
            }
        }

        public async Task<Response<ReportDto>> GetByLocationAsync(string location)
        {
            var contact = await _reportCollection.Find<ReportCollection>(x => x.Location == location).FirstOrDefaultAsync();

            return Response<ReportDto>.Success(_mapper.Map<ReportDto>(contact), 200);
        }
    }
}
