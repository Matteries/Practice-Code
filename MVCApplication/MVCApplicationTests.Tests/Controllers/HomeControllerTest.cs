using MVCApplication.Controllers;
using NUnit.Framework;
using System.Web.Mvc;
using Assert = NUnit.Framework.Assert;

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
        [TestCase("Allan Cano", "Allan Cano")]
        [TestCase("a.cano@outlook.co.uk", "a.cano@outlook.co.uk")]
        [TestCase("07779 678735", "07779 678735")]
        public void IndexReturnsStudentData(int testInput, bool expectedOutput)
        {

            // Act
            var indexTableResults = _sut.Index(testInput);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(indexTableResults));
        }

        [Test]
        public void AboutReturnsAValue()
        {

            // Act
            ViewResult result = _sut.About() as ViewResult;

            // Assert
            Assert.AreEqual("Text MVC", result.ViewBag.Message);
        }
    }
}
