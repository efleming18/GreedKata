using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests.SumEvenSidesCompleteFeature
{
    [TestFixture]
    class ScoreTwosFeature
    {
        private static readonly List<int>[] diceRollsWithLessThanTwoTwos =
        {
            new List<int> { 2 },
            new List<int> { 2, 2 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanTwoTwos")]
        public void GivenLessThanThreeTwos_WhenOnlyTwosAreRolled_ThenReturnZeroPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(0, actualPoints);
        }

        [Test]
        public void GivenExactlyThreeTwos_WhenOnlyTwosAreRolled_ThenReturnTwoHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2 };

            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(200, actualPoints);
        }

        // Is four of a kind only for 2s?
        [Test]
        public void GivenFourTwos_WhenOnlyTwosAreRolled_ThenReturnFourHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(400, actualPoints);
        }

        // Is five of a kind only for 2s?
        [Test]
        public void GivenFiveTwos_WhenOnlyTwosAreRolled_ThenReturnEightHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(800, actualPoints);
        }

        // Is six of a kind only for 2s?
        [Test]
        public void GivenSixTwos_WhenOnlyTwosAreRolled_ThenReturnSixteenHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(1600, actualPoints);
        }
    }
}
