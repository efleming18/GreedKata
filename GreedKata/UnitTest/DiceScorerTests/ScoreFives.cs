using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreFives
    {
        //lol, we suck. Stray fives are worth 50 points!
        [Test]
        public void GivenOneFive_ThenReturnFiftyPoints()
        {
            var diceToScore = new List<int> { 5, 0, 0, 0, 0 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(50, actualValue);
        }

        [Test]
        public void GivenTwoFives_ThenReturnOneHundredPoints()
        {
            var diceToScore = new List<int> { 5, 5, 0, 0, 0 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(100, actualValue);
        }

        [Test]
        public void GivenThreeFives_ThenReturnFiveHundredPoints()
        {
            var diceToScore = new List<int> { 5, 5, 5 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(500, actualValue);
        }

        [Test]
        public void GivenFourFives_ThenReturnFiveHundredAndFiftyPoints()
        {
            var diceToScore = new List<int> { 5, 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(550, actualValue);
        }

        [Test]
        public void GivenFiveFives_ThenReturnSixHundred()
        {
            var diceToScore = new List<int> { 5, 5, 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var actualValue = diceScorer.ScoreFives(diceToScore);

            Assert.AreEqual(600, actualValue);
        }
    }
}
