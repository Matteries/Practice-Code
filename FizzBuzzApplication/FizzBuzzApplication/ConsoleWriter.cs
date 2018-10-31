using System;

namespace FizzBuzzApplication
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteHost(string output)
        {
            Console.WriteLine(output);
        }
    }
}
