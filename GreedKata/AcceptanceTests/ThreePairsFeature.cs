using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    class ThreePairsFeature
    {
        private static List<int>[] diceRollsWithTheePairs =
        {
            new List<int> { 4, 4, 2, 2, 3, 3 },
            new List<int> { 3, 3, 4, 4, 6, 6 },
            new List<int> { 6, 6, 2, 2, 4, 4 },
            new List<int> { 2, 2, 6, 6, 3, 3 },
        };

        [Test]
        [TestCaseSource("diceRollsWithTheePairs")]
        public void GivenThreePairs_WhenDiceAreRolled_ThenReturnEightHundredPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var pointsScored = greed.GetTotalPoints(diceRolled);

            Assert.AreEqual(800, pointsScored);
        }
    }
}
