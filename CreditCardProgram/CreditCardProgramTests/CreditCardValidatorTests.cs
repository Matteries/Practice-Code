using CreditCardProgram;
using NUnit.Framework;
using System;

namespace CreditCardProgramTests
{
    [TestFixture]
    public class CreditCardValidatorTests
    {
        private CreditCardValidator _creditCardValidator;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _creditCardValidator = new CreditCardValidator();
        }

        static TestCaseData[] ExpectedCreditCards = new TestCaseData[]
        {
            new TestCaseData( new CreditCardValidator(), 8473986074875837, 7868, "test")
        };

        [Test]
        public void WhenPassedChars_GivesIncorrectInput_ReturnsFalse()
        {

            string cardNo = "";
            bool b = _creditCardValidator.StartValidator(cardNo).Equals("test");

            //Assert
            Assert.AreEqual(false, b);
        }

        //[Test]
        //public void GivenOutput_WhenDivisibleByTen_ReturnsExpectedOutput()
        //{
        //    //Act
        //    var divisibleOutput = _creditCardValidator.CreditCardOutput(10);

        //    //Assert
        //    Assert.AreEqual(true, divisibleOutput);
        //}

        //[Test]
        //public void GivenCardNumber_IsReversed_ReturnsExpectedOutput()
        //{
        //    //Act
        //    var reversedOutput = _creditCardValidator.ReversedCardNumber("4118767832987690");
        //    //Assert
        //    Assert.That("0967892387678114".ToArray(), Is.EqualTo(reversedOutput.ToArray()));
        //}

        //[Test]
        //public void GivenCardNumber_WhenEvenIsDoubled_ReturnsExpectedOutput()
        //{
        //    //Act
        //    var doubledOutput = _creditCardValidator.GetEvenValue("4");
        //    //Assert
        //    Assert.AreEqual(8, doubledOutput);
        //}
    }
}