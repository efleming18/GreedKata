using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreOnes
    {
        [Test]
        public void GiveOneOne_ThenReturnOneHundredPoints()
        {
            var diceToScore = new List<int> {1, 0, 0, 0, 0}; 
            var diceScorer = new DiceScorer();
            var actualScore = diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(100, actualScore);
        }

        [Test]
        public void GivenTwoOnes_ThenReturnTwoHundredPoints()
        {
            var diceToScore = new List<int> { 1, 1, 0, 0, 0 };
            var diceScorer = new DiceScorer();
            var actualScore = diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(200, actualScore);
        }
        
    }
}
