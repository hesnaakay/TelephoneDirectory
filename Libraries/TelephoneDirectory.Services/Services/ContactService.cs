using AutoMapper;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Data;

namespace TelephoneDirectory.Libraries.Services
{
    public class ContactService:IContactService
    {
        private readonly IMongoCollection<Contact> _contactCollection;
        private readonly IMapper _mapper;

        public ContactService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);

            var database = client.GetDatabase(databaseSettings.DatabaseName);

            _contactCollection = database.GetCollection<Contact>(databaseSettings.ContactCollectionName);
            _mapper = mapper;
        }
        public async Task<Response<List<ContactDto>>> GetAllAsync()
        {
            var contacts = await _contactCollection.Find(contact => true).ToListAsync();

            return Response<List<ContactDto>>.Success(_mapper.Map<List<ContactDto>>(contacts), 200);
        }
        public async Task<Response<ContactDto>> GetByIdAsync(string id)
        {
            var contact = await _contactCollection.Find<Contact>(x => x.Id== id).FirstOrDefaultAsync();

            return Response<ContactDto>.Success(_mapper.Map<ContactDto>(contact), 200);
        }
        public async Task<Response<List<ContactDto>>> GetAllByUserIdAsync(string userId)
        {
            var Contacts = await _contactCollection.Find<Contact>(x => x.UserId == userId).ToListAsync();

            return Response<List<ContactDto>>.Success(_mapper.Map<List<ContactDto>>(Contacts), 200);
        }

        public async Task<Response<ContactDto>> CreateAsync(ContactCreateDto ContactCreateDto)
        {
            var newContact = _mapper.Map<Contact>(ContactCreateDto);

            await _contactCollection.InsertOneAsync(newContact);

            return Response<ContactDto>.Success(_mapper.Map<ContactDto>(newContact), 200);
        }

        public async Task<Response<NoContent>> UpdateAsync(ContactDto ContactUpdateDto)
        {
            var updateContact = _mapper.Map<Contact>(ContactUpdateDto);

            var result = await _contactCollection.FindOneAndReplaceAsync(x => x.Id == ContactUpdateDto.Id, updateContact);

            if (result == null)
            {
                return Response<NoContent>.Fail("Contact not found", 404);
            }

            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> DeleteAsync(string id)
        {
            var result = await _contactCollection.DeleteOneAsync(x => x.Id == id);

            if (result.DeletedCount > 0)
            {
                return Response<NoContent>.Success(204);
            }
            else
            {
                return Response<NoContent>.Fail("Contact not found", 404);
            }
        }
        public async Task<Response<List<Contact>>> GetAllByLocationAsync(string location)
        {
            var Contacts = await _contactCollection.Find<Contact>(x => x.Location == location).ToListAsync();

            return Response<List<Contact>>.Success(_mapper.Map<List<Contact>>(Contacts), 200);
        }
    }
}
