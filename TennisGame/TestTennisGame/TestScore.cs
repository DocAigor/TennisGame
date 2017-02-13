using Game;
using NUnit.Framework;

namespace TestTennisGame
{
    [TestFixture]
    class TestScore
    {
        private Match match;

        [SetUp]
        public void Setup()
        {
            match = new Match("PlayerA", "PlayerB");
        }

        [Test]
        public void TestWinner()
        {
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Winner");
            Assert.AreEqual(score[1], "Loser");
        }

        [Test]
        public void TestLove()
        {
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Love");
            Assert.AreEqual(score[0], "Love");
        }

        [Test]
        public void TestFifteen()
        {
            //uno dei due Player fa punto
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Fifteen");
            Assert.AreNotEqual(score[1], "Fifteen");
        }

        [Test]
        public void TestThirty()
        {
            //uno dei due Player fa punto
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Thirty");
            Assert.AreNotEqual(score[1], "Thirty");
        }

        [Test]
        public void TestForty()
        {
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            var score = match.GetScore();
            Assert.AreNotEqual(score[0], "Forty");
            Assert.AreEqual(score[1], "Forty");
        }

        [Test]
        public void TestDeuce()
        {
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Deuce");
            Assert.AreEqual(score[1], "Deuce");
        }


        [Test]
        public void TestAdvantage()
        {
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score[0], "Advantage");
            Assert.AreNotEqual(score[1], "Advantage");
        }
    }
}
