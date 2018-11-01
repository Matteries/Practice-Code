using System;
using TextScrubberUI;
namespace ScrubberProgramStarter
{
    public static class ProgramStarter
    {
        public static void Main()
        {
            var textScrubberConsole = new TextScrubberUI.TextScrubberUI();
            textScrubberConsole.RawUserInput();
            Console.ReadLine();
        }
    }
}