using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreFives
    {
        private static readonly List<int>[] DiceRollsWithMoreThanThreeFives =
        {
            new List<int> { 5, 5, 5, 5 },
            new List<int> { 5, 5, 5, 5, 5 }
        };

        [Test]
        public void GivenOneFive_ThenReturnZeroPoints()
        {
            var diceToScore = new List<int> { 5, 0, 0, 0, 0 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(0, actualValue);
        }

        [Test]
        public void GivenThreeFives_ThenReturnFiveHundredPoints()
        {
            var diceToScore = new List<int> { 5, 5, 5 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(500, actualValue);
        }

        [Test]
        [TestCaseSource("DiceRollsWithMoreThanThreeFives")]
        public void GivenMoreThanThreeFives_ThenReturnFiveHundredPoints(List<int> diceToScore)
        {
            var diceScorer = new DiceScorer();
            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(500, actualValue);
        }
    }
}
