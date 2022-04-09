using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Test.MockData
{
    public class ContactMockData
    {
        public static Response<List<ContactDto>> getContactMockDataList()
        {
            var response = new Response<List<ContactDto>>()
            {
                Data = new List<ContactDto>() {
                     new ContactDto()
                     {
                       Id = "1",
                       Description = "",
                       Email ="",
                       Location ="",
                       PhoneNumber ="",
                       User = new User(),
                       UserId = ""
                     },
                     new ContactDto()
                     {
                       Id = "1",
                       Description = "",
                       Email ="",
                       Location ="",
                       PhoneNumber ="",
                       User = new User(),
                       UserId = ""
                     }
                },
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }
        public static Response<ContactDto> getContactMockData()
        {
            var response = new Response<ContactDto>()
            {
                Data = new ContactDto()
                {
                    Id = "1",
                    Description = "",
                    Email = "",
                    Location = "",
                    PhoneNumber = "",
                    User = new User(),
                    UserId = ""
                },
                Errors = new List<string>(),
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }

        public static Response<ContactDto> createContactMockData()
        {
            var response = new Response<ContactDto>()
            {
                Data = new ContactDto()
                {
                    Id = "1",
                    Description = "",
                    Email = "",
                    Location = "",
                    PhoneNumber = "",
                    User = new User(),
                    UserId = ""
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
