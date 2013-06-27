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

        private static readonly List<int>[] diceRollsWithMoreThanTwoTwos =
        {
            new List<int> { 2, 2, 2, 2 },
            new List<int> { 2, 2, 2, 2, 2 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanTwoTwos")]
        public void GivenLessThanThreeTwos_WhenOnlyTwosAreRolled_ThenReturnZeroPoints(Object diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(new List<int> { 2 });
            Assert.AreEqual(0, actualPoints);
        }

        [Test]
        public void GivenExactlyTwoTwos_WhenOnlyTwosAreRolled_ThenReturnTwoHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2 };

            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(200, actualPoints);
        }

        [Test]
        [TestCaseSource("diceRollsWithMoreThanTwoTwos")]
        public void GivenMoreThanTwoTwos_WhenOnlyTwosAreRolled_ThenReturnTwoHundredPoints(Object diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(new List<int> { 2, 2, 2, 2 });
            Assert.AreEqual(200, actualPoints);
        }
    }
}
