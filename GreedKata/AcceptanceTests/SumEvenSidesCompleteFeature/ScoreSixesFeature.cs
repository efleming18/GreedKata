using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests.SumEvenSidesCompleteFeature
{
    [TestFixture]
    class ScoreSixesFeature
    {
        private static readonly List<int>[] diceRollsWithLessThanThreeSixes =
        {
            new List<int> { 6 },
            new List<int> { 6, 6 }
        };

        private static readonly List<int>[] diceRollsWithMoreThanThreeSixes =
        {
            new List<int> { 6, 6, 6, 6 },
            new List<int> { 6, 6, 6, 6, 6 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanThreeSixes")]
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
            var diceRolled = new List<int> { 6, 6, 6 };

            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(600, actualPoints);
        }

        [Test]
        [TestCaseSource("diceRollsWithMoreThanThreeSixes")]
        public void GivenMoreThanFourFours_WhenOnlyFoursAreRolled_ThenReturnFourHundredPoints(List<int> diceRolled)
        {
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);

            var actualPoints = greed.GetTotalPoints(diceRolled);
            Assert.AreEqual(600, actualPoints);
        }

    }
}