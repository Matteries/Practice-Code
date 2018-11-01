using TextScrubberDomain;
using System;

namespace TextScrubberUIProject
{
    public class TextScrubberUI
    {
        private readonly TextScrubberLogic _scrubberLogic;

        public TextScrubberUI()
        {
            _scrubberLogic = new TextScrubberLogic();
        }

        public void RawUserInput()
        {
            Console.WriteLine("Input your raw text here, please.");
            var userInput = Console.ReadLine();

            Console.WriteLine(_scrubberLogic.StripHTMLTags(userInput));
        }
    }
}
