using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    class ScoreThrees
    {
        private static List<int>[] diceRollSsWithLessThanThreeThrees = { new List<int>{3},
                                                                         new List<int>{3, 3}
                                                                       };

        [Test]
        [TestCaseSource("diceRollSsWithLessThanThreeThrees")]
        public void GivenLessThanThreeThrees_WhenOnlyThreesAreRolled_ThenReturnZeroPoints(Object diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(new List<int> {3});
            Assert.AreEqual(0, actualPoints);
        }

        [Test]
        public void GivenExactlyThreeThrees_WhenOnlyThreesAreRolled_ThenReturnThreeHundredPoints()
        {
            var diceRolled = new List<int> { 3, 3, 3 };

            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(300, actualPoints);
        }
    }
}
