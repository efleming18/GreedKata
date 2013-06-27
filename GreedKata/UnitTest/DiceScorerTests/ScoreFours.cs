using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreFours
    {
        private static List<int>[] diceRollsWithLessThanThreeFours = { 
            new List<int> { }, 
            new List<int> { 4 }, 
            new List<int> { 4, 4 }
        };

        private static List<int>[] diceRollsWithMoreThanThreeFours = { 
            new List<int> { 4, 4, 4, 4 }, 
            new List<int> { 4, 4, 4, 4, 4 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanThreeFours")]
        public void GivenLessThanThreeFours_ThenReturnZeroPoints(List<int> diceRolls)
        {
            var diceToScore = new List<int> { 4 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFours(diceToScore);

            Assert.AreEqual(0, actualValue);
        }

        [Test]
        public void GivenThreeFours_ThenReturnFourHundredPoints()
        {
            var diceRolled = new List<int> { 4, 4, 4 };

            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreFours(diceRolled);
            Assert.AreEqual(400, actualPoints);
        }

        [Test]
        [TestCaseSource("diceRollsWithMoreThanThreeFours")]
        public void GivenMoreThanThreeFours_ThenReturnFourHundredPoints(List<int> diceRoll)
        {
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreFours(diceRoll);

            Assert.AreEqual(400, actualPoints);
        }
    }
}
