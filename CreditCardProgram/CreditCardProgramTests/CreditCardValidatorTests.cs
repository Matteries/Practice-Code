using System.Linq;
using CreditCardProgram;
using NUnit.Framework;

namespace CreditCardProgramTests
{
    [TestFixture]
    public class CreditCardValidatorTests
    {
        private CreditCardValidator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new CreditCardValidator();
        }

        [Test]
        [TestCase(0, false)]
        [TestCase(3, true)]
        [TestCase(8, false)]
        [TestCase(11477, true)]
        public void GivenValidNumber_IsOdd_ReturnsExpectedOutput(int testInput, bool expectedOutput)
        {
            //Arrange

            //Act
            var actualOutput = _sut.IsOdd(testInput);

            //Assert
            Assert.That(expectedOutput, Is.EqualTo(actualOutput));
        }

        [Test]
        public void GivenOutput_IsDivisibleByTen_ReturnsExpectedOutput()
        {
            //Arrange

            //Act
            var divisibleOutput = _sut.CreditCardOutput(10);
            //Assert
            Assert.That(true, Is.EqualTo(divisibleOutput));
        }

        [Test]
        public void GivenCardNumber_IsReversed_ReturnsExpectedOutput()
        {
            //Arrange

            //Act
            var reversedOutput = _sut.ReversedCardNumber("4118767832987690");
            //Assert
            Assert.That("0967892387678114".ToArray(), Is.EqualTo(reversedOutput.ToArray()));
        }

        [Test]
        public void GivenCardNumber_IsEvenDoubled_ReturnsExpectedOutput()
        {
            //Arrange

            //Act
            var doubledOutput = _sut.GetEvenValue("4");
            //Assert
            Assert.That(8, Is.EqualTo(doubledOutput));
        }

    }
}
