using System.Collections.Generic;

namespace TextScrubberApplication
{
    public class BadInputFilter
    {
        public List<string> NotAllowedStrings
        {
            get
            {
                return new List<string>
                {
                    "<script>",
                    "</script>",
                    "</p>",
                    "<p>",
                    "@",
                    "+",
                    "*"
                };
            }
        }
    }
}