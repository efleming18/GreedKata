using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreTwos
    {
        private static List<int>[] diceRollsWithLessThanThreeTwos = { 
            new List<int> { }, 
            new List<int> { 2 }, 
            new List<int> { 2, 2 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanThreeTwos")]
        public void GivenLessThanThreeTwos_ThenReturnZeroPoints(List<int> diceRolls)
        {
            var diceToScore = new List<int> { 2 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreTwos(diceToScore);

            Assert.AreEqual(0, actualValue);
        }

        [Test]
        public void GivenThreeTwos_ThenReturnTwoHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2 };

            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);
            Assert.AreEqual(200, actualPoints);
        }

        [Test]
        public void GivenFourTwos_ThenReturnFourHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(400, actualPoints);
        }

        [Test]
        public void GivenFiveTwos_ThenReturnEightHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(800, actualPoints);
        }

        [Test]
        public void GivenSixeTwos_ThenReturnSixteenHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(1600, actualPoints);
        }
    }
}
