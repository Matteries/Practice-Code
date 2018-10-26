using System;

namespace FizzBuzzApplication
{
    internal class FizzBuzzConsole
    {
        private int fizz = 3;
        private int buzz = 5;
        private int fizzbuzz = 15;

        public void FizzBuzzStarter()
        {

            for (var i = 1; i <= 100; i++)
            {

                var isDivisibleByThree = i % fizz == 0;
                var isDivisibleByFive = i % buzz == 0;
                var isDivisibleByFifteen = i % fizzbuzz == 0;

                if (isDivisibleByFifteen)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (isDivisibleByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (isDivisibleByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
