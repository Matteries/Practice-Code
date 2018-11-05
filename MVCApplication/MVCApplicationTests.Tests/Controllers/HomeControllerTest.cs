﻿using MVCApplication.Controllers;
using NUnit.Framework;
using System.Web.Mvc;
using MVCApplication.Models;
using Assert = NUnit.Framework.Assert;
using System;

namespace MVCApplicationTests.Tests.Controllers
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
        public void Index()
        {

            // Act
            ViewResult result = _sut.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void IndexReturnsAValue()
        {

            // Act
            ViewResult result = _sut.Index() as ViewResult;

            // Assert
            Assert.AreEqual("MVC Index", result.ViewBag.Message);
        }

        [Test]
        public void AboutReturnsAViewBagMessage()
        {

            // Act
            ViewResult result = _sut.About() as ViewResult;

            // Assert
            Assert.AreEqual("MVC About", result.ViewBag.Message);
        }

        [Test]
        public void Index_IsBeingSet_ByUserID()
        {
            int expected = new Random().Next();
            var target = new UserInfo() { ID = expected };
            Assert.AreEqual(expected, target.ID);
        }

        [Test]
        public void Index_IsBeingSet_ByUserName()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Name = expected };
            Assert.AreEqual(expected, target.Name);
        }

        [Test]
        public void Index_IsBeingSet_ByUserEmail()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Email = expected };
            Assert.AreEqual(expected, target.Email);
        }

        [Test]
        public void Index_IsBeingSet_ByUserPhoneNumber()
        {
            var expected = new Random().Next().ToString();
            var target = new UserInfo() { Number = expected };

            Assert.AreEqual(expected, target.Number);
        }
    }
}