using CollectionApp.Controllers;
using CollectionLogic.Entities;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class AuthControllerTest
    {
        private readonly AuthController _auth = new AuthController(null, null, null);
        private LoginEntity _login;

        [SetUp]
        public void Setup()
        {
            _login = new LoginEntity()
            {
                Username = "maarten.jakobs@gmail.com",
                Password = "sonu@123"
            };
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}