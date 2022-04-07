using AutoMapper;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Data;

namespace TelephoneDirectory.Libraries.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _userCollection;
        private readonly IMongoCollection<Contact> _contactCollection;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);

            var database = client.GetDatabase(databaseSettings.DatabaseName);

            _userCollection = database.GetCollection<User>(databaseSettings.UserCollectionName);
            _contactCollection = database.GetCollection<Contact>(databaseSettings.ContactCollectionName);
            _mapper = mapper;
        }

        public async Task<Response<List<UserDto>>> GetAllAsync()
        {
            var users = await _userCollection.Find(user => true).ToListAsync();

            return Response<List<UserDto>>.Success(_mapper.Map<List<UserDto>>(users), 200);
        }
        public async Task<Response<UserDto>> CreateAsync(UserDto UserDto)
        {
            var user = _mapper.Map<User>(UserDto);
            await _userCollection.InsertOneAsync(user);

            return Response<UserDto>.Success(_mapper.Map<UserDto>(user), 200);
        }

        public async Task<Response<UserDto>> GetByIdAsync(string id)
        {
            var user = await _userCollection.Find<User>(x => x.Id == id).FirstOrDefaultAsync();

            if (user == null)
            {
                return Response<UserDto>.Fail("User not found", 404);
            }

            return Response<UserDto>.Success(_mapper.Map<UserDto>(user), 200);
        }

        public async Task<Response<NoContent>> DeleteAsync(string id)
        {
            var result = await _userCollection.DeleteOneAsync(x => x.Id == id);

            if (result.DeletedCount > 0)
            {
                return Response<NoContent>.Success(204);
            }
            else
            {
                return Response<NoContent>.Fail("User not found", 404);
            }
        }
    }
}
