using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store_Utility
{
    //[TestClass]
    //public class AuthControllerTests
    //{
    //    [TestMethod]
    //    public async Task Register_ValidUser_ReturnsCreated()
    //    {
    //        // Arrange
    //        var userServiceMock = new Mock<IUserService>();
    //        var authController = new AuthController(userServiceMock.Object);
    //        var newUser = new User { Username = "testuser", Password = "testpassword" };

    //        // Act
    //        var result = await authController.Register(newUser);

    //        // Assert
    //        Assert.IsNotNull(result);
    //        Assert.IsInstanceOfType(result, typeof(CreatedResult));
    //        var createdResult = result as CreatedResult;
    //        Assert.AreEqual(201, createdResult.StatusCode);
    //    }

    //    [TestMethod]
    //    public async Task Register_InvalidUser_ReturnsBadRequest()
    //    {
    //        // Arrange
    //        var userServiceMock = new Mock<IUserService>();
    //        var authController = new AuthController(userServiceMock.Object);
    //        var invalidUser = new User { Username = "", Password = "testpassword" };

    //        // Act
    //        var result = await authController.Register(invalidUser);

    //        // Assert
    //        Assert.IsNotNull(result);
    //        Assert.IsInstanceOfType(result, typeof(BadRequestResult));
    //        var badRequestResult = result as BadRequestResult;
    //        Assert.AreEqual(400, badRequestResult.StatusCode);
    //    }

    //    [TestMethod]
    //    public async Task Login_ValidCredentials_ReturnsToken()
    //    {
    //        // Arrange
    //        var userServiceMock = new Mock<IUserService>();
    //        var authController = new AuthController(userServiceMock.Object);
    //        var userCredentials = new User { Username = "testuser", Password = "testpassword" };
    //        var token = "sampletoken";
    //        userServiceMock.Setup(x => x.GenerateToken(userCredentials)).ReturnsAsync(token);

    //        // Act
    //        var result = await authController.Login(userCredentials);

    //        // Assert
    //        Assert.IsNotNull(result);
    //        Assert.IsInstanceOfType(result, typeof(OkObjectResult));
    //        var okObjectResult = result as OkObjectResult;
    //        Assert.AreEqual(200, okObjectResult.StatusCode);
    //        Assert.AreEqual(token, okObjectResult.Value);
    //    }

    //    [TestMethod]
    //    public async Task Login_InvalidCredentials_ReturnsUnauthorized()
    //    {
    //        // Arrange
    //        var userServiceMock = new Mock<IUserService>();
    //        var authController = new AuthController(userServiceMock.Object);
    //        var invalidCredentials = new User { Username = "testuser", Password = "wrongpassword" };
    //        userServiceMock.Setup(x => x.GenerateToken(invalidCredentials)).ReturnsAsync((string)null);

    //        // Act
    //        var result = await authController.Login(invalidCredentials);

    //        // Assert
    //        Assert.IsNotNull(result);
    //        Assert.IsInstanceOfType(result, typeof(UnauthorizedResult));
    //        var unauthorizedResult = result as UnauthorizedResult;
    //        Assert.AreEqual(401, unauthorizedResult.StatusCode);
    //    }
    //}
}
