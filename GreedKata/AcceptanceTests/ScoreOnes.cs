using System;
using System.Collections.Generic;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    public class ScoreOnes
    {
        //This could probably use a better name/be moved to another file?
        //Yes :)
        [Test]
        public void GivenOnlyOneOne_WhenDiceAreRolled_ThenReturnOneHundredPoints()
        {
            var expectedPoints = 100;
            var testRoll = new List<int> { 1 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyTwoOnes_WhenDiceAreRolled_ThenReturnTwoHundredPoints()
        {
            var expectedPoints = 200;
            var testRoll = new List<int> { 1, 1 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenOnlyThreeOnes_WhenDiceAreRolled_ThenReturnOneThousandPoints()
        {
            var expectedPoints = 1000;
            var testRoll = new List<int> { 1, 1, 1 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
