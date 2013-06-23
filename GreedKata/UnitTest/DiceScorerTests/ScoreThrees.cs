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

        public void SetUp()
        {
            this._diceScorer = new DiceScorer();
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
    }
}
