using System.Collections.Generic;
using static System.Console;

namespace TextScrubberApplication
{
    public class TextScrubber
    {
        public string OriginalInput
        {
            get
            {
                WriteLine("Input your raw text here, please.");
                var userInput = ReadLine();
                InputCleaner(userInput);
                return null;
            }
        }

        private void InputCleaner(string userInput)
        {
            var badInputList = new BadInputFilter().NotAllowedStrings;
            StringCleaner(userInput, badInputList);
        }

        public string StringCleaner(string userInput, List<string> badInputList)
        {
            string cleanOutput = userInput;
            foreach (var c in badInputList)
            {
                cleanOutput = cleanOutput.Replace(c, string.Empty);

            }
            WriteLine(cleanOutput);
            return cleanOutput;
        }
    }
}