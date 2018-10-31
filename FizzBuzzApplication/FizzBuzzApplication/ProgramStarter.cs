using System;

namespace FizzBuzzApplication
{
    public static class ProgramStarter
    {
        public static void Main()
        {
            var fizzBuzzConsole = new FizzBuzzConsole();
            fizzBuzzConsole.FizzBuzzStarter();

            Console.ReadLine();
        }
    }
}
