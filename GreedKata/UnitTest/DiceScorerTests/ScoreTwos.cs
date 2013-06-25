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
        [Test]
        public void GivenOneTwo_ThenReturnZeroPoints()
        {
            var diceToScore = new List<int> { 2 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreTwos(diceToScore);

            Assert.AreEqual(0, actualValue);
        }
    }
}
