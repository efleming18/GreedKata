using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreThrees
    {
        private DiceScorer _diceScorer;

        private static List<int>[] diceRollsWithMoreThanThreeThrees = { new List<int> { 3, 3, 3, 3 },
                                                                        new List<int> { 3, 3, 3, 3, 3 }
                                                                      };

        [SetUp]
        public void SetUp()
        {
            _diceScorer = new DiceScorer();
        }

        [Test]
        public void GivenOneThree_ThenReturnZeroPoints()
        {
            var diceToScore = new List<int> { 3, 2, 4, 0, 0 };
            var actualScore = _diceScorer.ScoreThrees(diceToScore);

            Assert.AreEqual(0, actualScore);
        }

        [Test]
        public void GivenThreeThrees_ThenReturnThreeHundredPoints()
        {
            var diceToScore = new List<int> { 3, 3, 3, 0, 0 };
            var actualScore = _diceScorer.ScoreThrees(diceToScore);

            Assert.AreEqual(300, actualScore);
        }

        [Test]
        [TestCaseSource("diceRollsWithMoreThanThreeThrees")]
        public void GivenMoreThanThreeThrees_WhenDiceAreRolled_ReturnThreeHundredPoints(List<int> diceToScore)
        {
            var actualScore = _diceScorer.ScoreThrees(diceToScore);

            Assert.AreEqual(300, actualScore);
        }
    }
}
