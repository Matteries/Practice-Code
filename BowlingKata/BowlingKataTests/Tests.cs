using NUnit.Framework;
using BowlingKata;

namespace BowlingKataTests
{
    [TestFixture]
    class Tests
    {
        public class BowlingGameTest
        {
            private Game _sut;

            [SetUp]
            protected void Setup()
            {
                _sut = new Game();
            }

            [Test]
            public void TestGutterGame()
            {
                RollPins(_sut, 20, 0);
                Assert.That(0, Is.EqualTo(_sut.Score));
            }

            [Test]
            public void TestHittingOnePinPerRoll()
            {
                RollPins(_sut, 20, 1);
                Assert.That(20, Is.EqualTo(_sut.Score));
            }

            [Test]
            public void TestOneSpare()
            {
                RollSpare(_sut);
                _sut.Roll(3);
                RollPins(_sut, 17, 0);

                Assert.That(16, Is.EqualTo(_sut.Score));
            }
            [Test]
            public void SparesOnEveryFrame()
            {
                RollPins(_sut, 21, 5);

                Assert.That(150, Is.EqualTo(_sut.Score));
            }

            [Test]
            public void TestOneStrike()
            {
                RollStrike(_sut);
                _sut.Roll(3);
                _sut.Roll(4);
                RollPins(_sut, 16, 0);

                Assert.That(24, Is.EqualTo(_sut.Score));
            }

            [Test]
            public void TestPerfectGame()
            {
                RollPins(_sut, 12, 10);

                Assert.That(300, Is.EqualTo(_sut.Score));
            }

            private void RollStrike(Game _sut)
            {
                _sut.Roll(10);
            }

            private void RollSpare(Game _sut)
            {
                _sut.Roll(5);
                _sut.Roll(5);
            }

            private void RollPins(Game _sut, int numberofRolls, int pinsHitPerRoll)
            {
                for (int i = 0; i < numberofRolls; i++)
                {
                    _sut.Roll(pinsHitPerRoll);
                }
            }
        }
    }
}