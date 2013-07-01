using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    class ScoreThreePairsShould
    {
        private static List<int>[] diceRollsWithTheePairs =
        {
            new List<int> { 1, 1, 2, 2, 3, 3 },
            new List<int> { 1, 1, 2, 2, 4, 4 },
            new List<int> { 6, 6, 2, 2, 3, 3 },
            new List<int> { 1, 1, 5, 5, 3, 3 },
        };

        private static List<int>[] diceRollsWithThreeDistinctValuesButNotPairs =
        {
            new List<int> { 1, 1, 1, 2, 3, 3 },
            new List<int> { 1, 1, 2, 2, 2, 4 },
            new List<int> { 6, 6, 2, 3, 3, 3 },
            new List<int> { 1, 1, 5, 5, 5, 3 },
        };

        [Test]
        [TestCaseSource("diceRollsWithTheePairs")]
        public void GivenThreePairs_ThenReturnEightHundredPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();

            var pointsScored = diceScorer.ScoreThreePairs(diceRolled);

            Assert.AreEqual(800, pointsScored);
        }

        [Test]
        [TestCaseSource("diceRollsWithThreeDistinctValuesButNotPairs")]
        public void NotReturnTwelveHundredPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();

            var pointsScored = diceScorer.ScoreThreePairs(diceRolled);

            Assert.AreNotEqual(800, pointsScored);
        }
    }
}
