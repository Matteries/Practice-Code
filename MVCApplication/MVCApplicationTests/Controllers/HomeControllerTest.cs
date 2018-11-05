using MVCApplication.Models;
using MVCApplication.Controllers;
using NUnit.Framework;
using System.Web.Mvc;
using Assert = NUnit.Framework.Assert;
using System;

namespace MVCApplicationTests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private HomeController _sut;


        [SetUp]
        public void Setup()
        {
            // Arrange
            _sut = new HomeController();
        }

        [Test]
        public void AssertsIf_IndexPage_Exists()
        {

            // Act
            ViewResult result = _sut.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Returns_IndexPage_ViewBagMessage()
        {

            // Act
            ViewResult result = _sut.Index() as ViewResult;

            // Assert
            Assert.AreEqual("MVC Index", result.ViewBag.Message);
        }

        [Test]
        public void Returns_AboutPage_ViewBagMessage()
        {

            // Act
            ViewResult result = _sut.About() as ViewResult;

            // Assert
            Assert.AreEqual("MVC About", result.ViewBag.Message);
        }

        [Test]
        public void Index_IsBeingSetWith_UserID()
        {
            var expected = new Random().Next();
            var target = new UserInfo() { ID = expected };
            Assert.AreEqual(expected, target.ID);
        }

        [Test]
        public void Index_IsBeingSetWith_UserName()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Name = expected };
            Assert.AreEqual(expected, target.Name);
        }

        [Test]
        public void Index_IsBeingSetWith_UserEmail()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Email = expected };
            Assert.AreEqual(expected, target.Email);
        }

        [Test]
        public void Index_IsBeingSetWith_UserPhoneNumber()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Number = expected };

            Assert.AreEqual(expected, target.Number);
        }
    }
}
