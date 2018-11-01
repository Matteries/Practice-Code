using NUnit.Framework;
using TextScrubberDomain;

namespace TextScrubberTests
{
    [TestFixture]
    public class TextScrubberTests
    {
        private TextScrubberLogic _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new TextScrubberLogic();
        }

        [Test]
        [TestCase("<script>Hello, World!</script>", "Hello, World!")]
        [TestCase("<p>This is a test</p>", "This is a test")]
        [TestCase("<head>This is a header</head>", "This is a header")]
        [TestCase("<html>This is a html code snippet</html>", "This is a html code snippet")]
        [TestCase("<body>This is some body HTML code</body>", "This is some body HTML code")]
        public void GivenOutput_DoesntContainAnyHTMLTags(string testInput, string expectedOutput)
        {
            Assert.That(expectedOutput, Is.EqualTo(_sut.StripHTMLTags(testInput)));
        }
    }
}