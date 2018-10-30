using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditCardProgram
{
    public class CreditCardValidator
    {
        private int _oddValue;
        private int _evenValue;

        public void CardNumberEntryMethod()
        {
                Console.WriteLine("Please enter your 16 digit credit card number below:");
                var cardNumber = Console.ReadLine();
                CardNumberPos(cardNumber);
                ReversedCardNumber(cardNumber);
        }

        public IEnumerable<char> ReversedCardNumber(string cardNumber)
        {
            return cardNumber.Reverse();
        }

        private void CardNumberPos(string reversedCardNumber)
        {
            var toUse = ReversedCardNumber(reversedCardNumber).ToArray();

            for (var i = 0; i < toUse.Length; i++)
            {
                if (IsOdd(i + 1))
                {
                    _oddValue = _oddValue + int.Parse(toUse[i].ToString());
                }
                else
                {
                    _evenValue = _evenValue + GetEvenValue(toUse[i].ToString());
                }
            }

            Console.WriteLine(CreditCardOutput(_oddValue + _evenValue));
        }

        public int GetEvenValue(string inputNumber)
        {
            var doubledValue = int.Parse(inputNumber) * 2;
            var evenTotal = doubledValue.ToString().Sum(c => c - '0');
            return evenTotal;
        }

        public bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public bool CreditCardOutput(int value)
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