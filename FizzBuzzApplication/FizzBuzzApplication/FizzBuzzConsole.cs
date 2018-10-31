using System;

namespace FizzBuzzApplication
{
    public class FizzBuzzConsole
    {
        private readonly int _fizz = 3;
        private readonly int _buzz = 5;
        private readonly int _fizzbuzz = 15;

        public void FizzBuzzStarter()
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine("\n_____\n{0}", i);

                IsDivisibleByFifteen(i);
                IsDivisibleByFive(i);
                IsDivisibleByThree(i);
            }
        }

        public bool IsDivisibleByFifteen(int i)
        {
            var isDivisibleByFifteen = i % _fizzbuzz == 0;
            ConsoleChecker(isDivisibleByFifteen, "Fizz Buzz");
            return isDivisibleByFifteen;
        }

        public bool IsDivisibleByFive(int i)
        {
            var isDivisibleByFive = i % _buzz == 0;
            ConsoleChecker(isDivisibleByFive, "Buzz");
            return isDivisibleByFive;
        }

        public bool IsDivisibleByThree(int i)
        {
            var isDivisibleByThree = i % _fizz == 0;
            ConsoleChecker(isDivisibleByThree, "Fizz");
            return isDivisibleByThree;
        }

        private void ConsoleChecker(bool check, string text)
        {
            if (check)
            {
                Console.WriteLine(text);
            }
        }
    }
}
