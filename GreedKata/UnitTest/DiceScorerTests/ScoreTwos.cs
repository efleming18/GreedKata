using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreTwos
    {
        private static List<int>[] diceRollsWithLessThanThreeTwos = { 
            new List<int> { }, 
            new List<int> { 2 }, 
            new List<int> { 2, 2 }
        };

        [Test]
        [TestCaseSource("diceRollsWithLessThanThreeTwos")]
        public void GivenLessThanThreeTwos_ThenReturnZeroPoints(List<int> diceRolls)
        {
            var diceToScore = new List<int> { 2 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreTwos(diceToScore);

            Assert.AreEqual(0, actualValue);
        }

        [Test]
        public void GivenThreeTwos_ThenReturnTwoHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2 };

            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);
            Assert.AreEqual(200, actualPoints);
        }

        [Test]
        public void GivenFourTwos_ThenReturnFourHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(400, actualPoints);
        }

        //I only made the test above pass. Is that ok or should I have made them all pass? 
        //Sorry about this weekend, I will for sure be checking in a lot tomorrow.
        //Go ahead and make this pass and the next ones if you think that is the right way.
        //It doesn't matter to me! I'm fine with either to get this puppy done.
        //Also, I'm not sure if the bonus just applies to 2's or not lol I'm confused on those rules.
        [Test]
        public void GivenFiveTwos_ThenReturnEightHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(800, actualPoints);
        }

        [Test]
        public void GivenSixTwos_ThenReturnSixteenHundredPoints()
        {
            var diceRolled = new List<int> { 2, 2, 2, 2, 2, 2 };
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRolled);

            Assert.AreEqual(1600, actualPoints);
        }
    }
}
