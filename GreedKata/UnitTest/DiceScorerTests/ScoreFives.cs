using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreFives
    {
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
    }
}
