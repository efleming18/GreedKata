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
        private DiceScorer _diceScorer;

        [SetUp]
        public void SetUp()
        {
            this._diceScorer = new DiceScorer();
        }

        [Test]
        public void GivenOneOne_ThenReturnOneHundredPoints()
        {
            var diceToScore = new List<int> {1, 0, 0, 0, 0};
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(100, actualScore);
        }

        [Test]
        public void GivenTwoOnes_ThenReturnTwoHundredPoints()
        {
            var diceToScore = new List<int> { 1, 1, 0, 0, 0 };
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(200, actualScore);
        }

        [Test]
        public void GivenThreeOnes_ThenReturnOneThousandPoints()
        {
            var diceToScore = new List<int> { 1, 1, 1, 0, 0 };
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(1000, actualScore);
        }

        [Test]
        public void GivenFourOnes_ThenReturnOneThousandOneHundredPoints()
        {
            var diceToScore = new List<int> { 1, 1, 1, 1, 0 };
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(1100, actualScore);
        }

        //For the rest of them I don't think we will have as many tests but since 1 is the most complicated I think its good to test all cases.
        //Oh and I didn't see anything to refactor =(, so this test since it passes right out of the gate will be my refactor :)
        [Test]
        public void GivenFiveOnes_ThenReturnOneThousandTwoHundredPoints()
        {
            var diceToScore = new List<int> { 1, 1, 1, 1, 1 };
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(1200, actualScore);
        }
    }
}
