using System;
using TextScrubberUIProject;

namespace ScrubberProgramStarter
{
    public static class ProgramStarter
    {
        public static void Main()
        {
            var textScrubberConsole = new TextScrubberUI();
            textScrubberConsole.RawUserInput();
            Console.ReadLine();
        }
    }
}