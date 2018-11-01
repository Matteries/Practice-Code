namespace TextScrubberDomain
{
    public class TextScrubberLogic
    {
        public string StripHTMLTags(string userInput)
        {
            var badInputList = new BadInputFilter().NotAllowedStrings;
            string cleanOutput = userInput;

            foreach (var c in badInputList)
            {
                cleanOutput = cleanOutput.Replace(c, "");
            }

            return cleanOutput;
        }
    }
}