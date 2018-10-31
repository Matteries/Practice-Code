using System;
using System.Linq;
using Moq;
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
            _sut = new FizzBuzzConsole(new ConsoleWriter());
        }

        [Test]
        [TestCase(3, false)]
        [TestCase(15, true)]
        [TestCase(120, true)]
        [TestCase(8, false)]
        [TestCase(15015, true)]
        public void GivenOutput_IsOfValue_FizzBuzz(int testInput, bool expectedOutput)
        {
            var fizzbuzzOutput = _sut.IsDivisibleByFifteen(testInput);

            Assert.That(expectedOutput, Is.EqualTo(fizzbuzzOutput));
        }

        [Test]
        [TestCase(22, false)]
        [TestCase(3, true)]
        [TestCase(8, false)]
        [TestCase(30, true)]
        [TestCase(3003, true)]
        public void GivenOutput_IsOfValue_Fizz(int testInput, bool expectedOutput)
        {
            var fizzOutput = _sut.IsDivisibleByThree(testInput);

            Assert.That(expectedOutput, Is.EqualTo(fizzOutput));
        }

        [Test]
        [TestCase(3, false)]
        [TestCase(5, true)]
        [TestCase(25, true)]
        [TestCase(8, false)]
        [TestCase(10005, true)]
        public void GivenOutput_IsOfValue_Buzz(int testInput, bool expectedOutput)
        {

            var buzzOutput = _sut.IsDivisibleByFive(testInput);

            Assert.That(expectedOutput, Is.EqualTo(buzzOutput));
        }

        [Test]
        public void GivenOutput_IsOfValue(int testInput, bool expectedOutput)
        {
            var mockConsoleWriter = new Mock<IConsoleWriter>();
            var sut = new FizzBuzzConsole(mockConsoleWriter.Object);

            sut.FizzBuzzStarter();
        }
    }
}