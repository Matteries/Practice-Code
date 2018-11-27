using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTests
{
    [TestFixture]
    public class Tests
    {
        private Game _sut;

        [SetUp]
        public void Create_NewInstanceOf_Game()
        {
            _sut = new Game();
        }

        void AmountOf_RollsIn_ASingleTurn(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _sut.Roll(pins);
            }
        }

        [Test]
        public void Create_NewInstanceOfA_RollInGame()
        {
            AmountOf_RollsIn_ASingleTurn(20, 0);
            Assert.That(_sut.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Create_NewInstanceOfA_SingleRoll()
        {
            AmountOf_RollsIn_ASingleTurn(20, 1);
            Assert.That(_sut.Score(), Is.EqualTo(20));
        }

        [Test]
        public void InstanceOf_RollingASpareOnFirstFrame()
        {
            _sut.Roll(9);
            _sut.Roll(1);
            AmountOf_RollsIn_ASingleTurn(18, 1);

            Assert.That(_sut.Score(), Is.EqualTo(29));
        }

        [Test]
        public void InstanceOf_SparesOnEveryFrame()
        {
            AmountOf_RollsIn_ASingleTurn(21, 5);

            Assert.That(_sut.Score(), Is.EqualTo(150));
        }

        [Test]
        public void InstanceOf_RollingAPerfectGame()
        {
            AmountOf_RollsIn_ASingleTurn(12, 10);

            Assert.That(_sut.Score(), Is.EqualTo(300));
        }
    }
}