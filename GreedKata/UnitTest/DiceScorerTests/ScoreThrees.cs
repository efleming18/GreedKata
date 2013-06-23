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
        [Test]
        public void GivenOneThree_ThenReturnZeroPoints()
        {
            var diceToScore = new List<int> { 3, 2, 4, 0, 0 };
            var diceScorer = new DiceScorer();
            var actualScore = diceScorer.ScoreThrees(diceToScore);

            Assert.AreEqual(0, actualScore);
        }
    }
}
