using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    class ScoreThreesFeature
    {
        private static List<int>[] diceRollsWithLessThanThreeThrees = { new List<int> { 3 },
                                                                         new List<int>{ 3, 3 }
                                                                      };

        private static List<int>[] diceRollsWithMoreThanThreeThrees = { new List<int> { 3, 3, 3, 3 },
                                                                        new List<int> { 3, 3, 3, 3, 3 }
                                                                      };

        [Test]
        [TestCaseSource("diceRollsWithLessThanThreeThrees")]
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

        [Test]
        [TestCaseSource("diceRollsWithMoreThanThreeThrees")]
        public void GivenMoreThanThreeThrees_WhenOnlyThreesAreRolled_ThenReturnThreeHundredPoints(Object diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(new List<int> { 3, 3, 3, 3 });
            Assert.AreEqual(300, actualPoints);
        }

    }
}
