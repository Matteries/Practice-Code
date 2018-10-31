using System.Linq;
using FizzBuzzApplication;
using NUnit.Framework;

namespace FizzBuzzApplicationTests
{
    [TestFixture]
    public class FizzBuzzApplicationTests
    {
        private FizzBuzzConsole _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new FizzBuzzConsole();
        }

        [Test]
        [TestCase(3, false)]
        [TestCase(4, true)]
        [TestCase(8, false)]
        [TestCase(11478, true)]
        public void GivenOutput_IsOfValue_FizzBuzz(int testInput, bool expectedOutput)
        {
            //Arrange

            //Act
            var fizzbuzzOutput = _sut.IsDivisibleByFifteen(testInput);

            //Assert
            Assert.That(expectedOutput, Is.EqualTo(fizzbuzzOutput));
        }
    }
}
