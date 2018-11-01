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
    }
}