using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests.SumEvenSidesCompleteFeature
{
    [TestFixture]
    class ScoreFoursFeature
    {
        private static readonly List<int>[] diceRollsWithLessThanFourFours =
        {
            new List<int> { 4 },
            new List<int> { 4, 4 }
        };

        private static readonly List<int>[] diceRollsWithMoreThanFourFours =
        {
            new List<int> { 4, 4, 4, 4 },
            new List<int> { 4, 4, 4, 4, 4 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanFourFours")]
        public void GivenLessThanThreeFours_WhenOnlyFoursAreRolled_ThenReturnZeroPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(0, actualPoints);
        }

        [Test]
        public void GivenExactlyThreeFours_WhenOnlyFoursAreRolled_ThenReturnFourHundredPoints()
        {
            var diceRolled = new List<int> { 4, 4, 4 };

            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(400, actualPoints);
        }

        [Test]
        [TestCaseSource("diceRollsWithMoreThanFourFours")]
        public void GivenMoreThanFourFours_WhenOnlyFoursAreRolled_ThenReturnFourHundredPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(400, actualPoints);
        }
    }
}
