using System.Collections.Generic;

namespace TextScrubberDomain
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
                    "<h1>",
                    "</h1>",
                    "<h2>",
                    "</h2>",
                    "<h3>",
                    "</h3>",
                    "</p>",
                    "<p>",
                    "<html>",
                    "</html>",
                    "<body>",
                    "</body>",
                    "<head>",
                    "</head>"
                };
            }
        }
    }
}