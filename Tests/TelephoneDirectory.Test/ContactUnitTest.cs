using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Net;
using TelephoneDirectory.Libraries.Core;
using TelephoneDirectory.Libraries.Services;
using TelephoneDirectory.Services.Controllers;
using TelephoneDirectory.Test.MockData;
using Xunit;

namespace TelephoneDirectory.Test
{
    public class ContactUnitTest
    {
        [Fact]
        public async void GetAll()
        {
            //Arrange
            var userService = new Mock<IContactService>();
            userService.Setup(_ => _.GetAllAsync()).ReturnsAsync(ContactMockData.getContactMockDataList());
            var sut = new ContactsController(userService.Object);

            //Act
            var result = await sut.GetAll();

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void GetById()
        {
            string id = "624af708be344022aa30beef";

            //Arrange
            var userService = new Mock<IContactService>();
            userService.Setup(_ => _.GetByIdAsync(id)).ReturnsAsync(ContactMockData.getContactMockData());
            var sut = new ContactsController(userService.Object);

            //Act
            var result = await sut.GetById(id);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void Create()
        {
            var userDto = new ContactCreateDto()
            {
                Description = "",
                Email = "",
                Location = "",
                PhoneNumber = "",
                UserId = ""
            };

            //Arrange
            var userService = new Mock<IContactService>();
            userService.Setup(_ => _.CreateAsync(userDto)).ReturnsAsync(ContactMockData.createContactMockData());
            var sut = new ContactsController(userService.Object);

            //Act
            var result = await sut.Create(userDto);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void Delete()
        {
            string id = "624af708be344022aa30beef";

            //Arrange
            var userService = new Mock<IContactService>();
            userService.Setup(_ => _.DeleteAsync(id)).ReturnsAsync(ContactMockData.DeleteMockData());
            var sut = new ContactsController(userService.Object);

            //Act
            var result = await sut.Delete(id);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
    }
}
