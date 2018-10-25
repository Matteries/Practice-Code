namespace CreditCardProgram
{
    public class CreditCardHelper
    {
        public static void Main(string[] args)
        {
            var creditCardValidator = new CreditCardValidator();
            creditCardValidator.CardNumberEntryMethod();
        }
    }
}