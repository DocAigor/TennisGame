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
            Assert.AreEqual(score.Item1, "Winner");
            Assert.AreEqual(score.Item2, "Loser");
        }

        [Test]
        public void TestLove()
        {
            var score = match.GetScore();
            Assert.AreEqual(score.Item1, "Love");
            Assert.AreEqual(score.Item2, "Love");
        }

        [Test]
        public void TestFifteen()
        {
            //uno dei due Player fa punto
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score.Item1, "Fifteen");
            Assert.AreNotEqual(score.Item2, "Fifteen");
        }

        [Test]
        public void TestThirty()
        {
            //uno dei due Player fa punto
            match.Player1.AddPoint();
            match.Player1.AddPoint();
            var score = match.GetScore();
            Assert.AreEqual(score.Item1, "Thirty");
            Assert.AreNotEqual(score.Item2, "Thirty");
        }

        [Test]
        public void TestForty()
        {
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            match.Player2.AddPoint();
            var score = match.GetScore();
            Assert.AreNotEqual(score.Item1, "Forty");
            Assert.AreEqual(score.Item2, "Forty");
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
            Assert.AreEqual(score.Item1, "Deuce");
            Assert.AreEqual(score.Item2, "Deuce");
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
            Assert.AreEqual(score.Item1, "Advantage");
            Assert.AreNotEqual(score.Item2, "Advantage");
        }
    }
}