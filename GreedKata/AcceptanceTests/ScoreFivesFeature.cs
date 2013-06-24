using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    class ScoreFivesFeature
    {
        //lol, we suck. Stray fives are worth 50 points!
        [Test]
        public void GivenOnlyOneFive_WhenDiceAreRolled_ThenReturnFiftyPoints()
        {
            var diceToScore = new List<int> { 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceToScore);

            Assert.AreEqual(50, actualPoints);
        }

        [Test]
        public void GivenOnlyTwoFives_WhenDiceAreRolled_ThenReturnOneHundredPoints()
        {
            var diceToScore = new List<int> { 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceToScore);

            Assert.AreEqual(100, actualPoints);
        }

        [Test]
        public void GivenOnlyThreeFives_WhenDiceAreRolled_ThenReturnFiveHundredPoints()
        {
            var diceRoll = new List<int> { 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRoll);

            Assert.AreEqual(500, actualPoints);
        }

        [Test]
        public void GivenOnlyFourFives_WhenDiceAreRolled_ThenReturnFiveHundredAndFiftyPoints()
        {
            var diceToScore = new List<int> { 5, 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceToScore);

            Assert.AreEqual(550, actualPoints);
        }

        [Test]
        public void GivenOnlyFiveFives_WhenDiceAreRolled_ThenReturnSixHundredPoints()
        {
            var diceToScore = new List<int> { 5, 5, 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceToScore);

            Assert.AreEqual(600, actualPoints);
        }
    }
}
