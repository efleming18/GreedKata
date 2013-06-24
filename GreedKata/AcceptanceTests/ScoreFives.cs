using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    class ScoreFives
    {
        private static List<int>[] DiceRollsWithLessThanThreeFives = { new List<int> { },
                                                                       new List<int> { 5 },
                                                                       new List<int> { 5, 5 }
                                                                     };

        [Test]
        [TestCaseSource("DiceRollsWithLessThanThreeFives")]
        public void GivenLessThanThreeFives_WhenDiceAreRolled_ThenReturnZeroPoints(List<int> diceRoll)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRoll);

            Assert.AreEqual(0, actualPoints);
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
    }
}
