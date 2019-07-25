using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditCardProgram
{
    public class CreditCardValidator
    {
        private int _oddValue;
        private int _evenValue;
        private string cardNo;

        public void StartValidator()
        {
            var cardNoValid = false;
            while(!cardNoValid)
            {
                cardNo = GetCardNumber();
                cardNoValid = IsCardNumberValid(cardNo);
            }
            CardNumberPos(cardNo);
            ReversedCardNumber(cardNo);
        }

        public bool IsCardNumberValid(string cardNo)
        {
            if (cardNo.Length != 16 || !cardNo.All(x => char.IsDigit(x)) || cardNo.All(y => y == 0))
            {
                Console.WriteLine("INFO: Credit card number must be 16 digits - try another credit card number!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private string GetCardNumber()
        {
                Console.WriteLine("Please submit your 16 digit credit card number below:");
                return Console.ReadLine();
        }

        private void CardNumberPos(string reversedCardNumber)
        {
            var toUse = ReversedCardNumber(reversedCardNumber).ToArray();

            for (var i = 0; i < toUse.Length; i++)
            {
                if (IsOdd(i + 1))
                {
                    _oddValue += int.Parse(toUse[i].ToString());
                }

                else
                {
                    _evenValue += GetEvenValue(toUse[i].ToString());
                }
            }

            Console.WriteLine(CreditCardOutput(_oddValue + _evenValue));
        }

        private IEnumerable<char> ReversedCardNumber(string cardNumber)
        {
            return cardNumber.Reverse();
        }

        private int GetEvenValue(string inputNumber)
        {
            var doubledValue = int.Parse(inputNumber) * 2;
            var evenTotal = doubledValue.ToString().Sum(c => c - '0');
            return evenTotal;
        }

        private bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private bool CreditCardOutput(int value)
        {
            if (value % 10 == 0)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}