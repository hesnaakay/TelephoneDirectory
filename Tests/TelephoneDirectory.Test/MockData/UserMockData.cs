using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Test.MockData
{
    public class UserMockData
    {
        public static Response<List<UserDto>> getUserMockDataList()
        {
            var response = new Response<List<UserDto>>()
            {
                Data = new List<UserDto>() {
                    new UserDto()
            {
                Id = "1",
                Company="B",
                Name="Test",
                Surname ="Test",
            },
            new UserDto()
            {
                Id = "1",
                Company="A",
                Name="Test",
                Surname ="Test",
            },},
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }
        public static Response<UserDto> getUserMockData()
        {
            var response = new Response<UserDto>()
            {
                Data = new UserDto()
                {
                    Id = "1",
                    Company = "B",
                    Name = "Test",
                    Surname = "Test",
                },
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }

        public static Response<UserDto> createUserMockData()
        {
            var response = new Response<UserDto>()
            {
                Data = new UserDto()
                {
                    Id = "1",
                    Company = "B",
                    Name = "Test",
                    Surname = "Test",
                },
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }
        public static Response<NoContent> DeleteMockData()
        {
            var response = new Response<NoContent>()
            {
                Data = new NoContent(),
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }
    }
}
