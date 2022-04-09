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
    public class UserUnitTest
    {
        [Fact]
        public async void GetAll()
        {
            //Arrange
            var userService = new Mock<IUserService>();
            userService.Setup(_ => _.GetAllAsync()).ReturnsAsync(UserMockData.getUserMockDataList());
            var sut = new UsersController(userService.Object);

            //Act
            var result = await sut.GetAll();

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void GetById()
        {
            string id = "624af0c9522d9635f36b2d70";

            //Arrange
            var userService = new Mock<IUserService>();
            userService.Setup(_ => _.GetByIdAsync(id)).ReturnsAsync(UserMockData.getUserMockData());
            var sut = new UsersController(userService.Object);

            //Act
            var result = await sut.GetById(id);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void Create()
        {
            var userDto = new UserDto()
            {
                Company = "B",
                Name = "Test",
                Surname = "Test",
            };

            //Arrange
            var userService = new Mock<IUserService>();
            userService.Setup(_ => _.CreateAsync(userDto)).ReturnsAsync(UserMockData.createUserMockData());
            var sut = new UsersController(userService.Object);

            //Act
            var result = await sut.Create(userDto);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
        [Fact]
        public async void Delete()
        {
            string id = "624af0c9522d9635f36b2d70";

            //Arrange
            var userService = new Mock<IUserService>();
            userService.Setup(_ => _.DeleteAsync(id)).ReturnsAsync(UserMockData.DeleteMockData());
            var sut = new UsersController(userService.Object);

            //Act
            var result = await sut.Delete(id);

            //Assert
            Assert.IsType<ObjectResult>(result as ObjectResult);
        }
    }
}
