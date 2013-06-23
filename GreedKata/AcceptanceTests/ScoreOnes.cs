using System;
using System.Collections.Generic;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    public class ScoreOnes
    {
        private Greed _greed;

        [SetUp]
        public void SetUp()
        {
            var diceScorer = new DiceScorer();
            _greed = new Greed(diceScorer);
        }

        [Test]
        public void GivenOnlyOneOne_WhenDiceAreRolled_ThenReturnOneHundredPoints()
        {
            var expectedPoints = 100;
            var testRoll = new List<int> { 1 };

            var actualPoints = _greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyTwoOnes_WhenDiceAreRolled_ThenReturnTwoHundredPoints()
        {
            var expectedPoints = 200;
            var testRoll = new List<int> { 1, 1 };

            var actualPoints = _greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyThreeOnes_WhenDiceAreRolled_ThenReturnOneThousandPoints()
        {
            var expectedPoints = 1000;
            var testRoll = new List<int> { 1, 1, 1 };

            var actualPoints = _greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyFourOnes_WhenDiceAreRolled_ThenReturnOneThousandOneHundredPoints()
        {
            var expectedPoints = 1100;
            var testRoll = new List<int> { 1, 1, 1, 1 };

            var actualPoints = _greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyFiveOnes_WhenDiceAreRolled_ThenReturnOneThousandTwoHundredPoints()
        {
            var expectedPoints = 1200;
            var testRoll = new List<int> { 1, 1, 1, 1, 1 };

            var actualPoints = _greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
