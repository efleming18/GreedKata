﻿using System;
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
        public void GiveOneOne_ThenReturnOneHundredPoints()
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

        //I really like this naming convention for these tests. Very clear on what each test is actually testing. Good job!
        [Test]
        public void GiveThreeOnes_ThenReturnOneThousandPoints()
        {
            var diceToScore = new List<int> { 1, 1, 1, 0, 0 };
            var actualScore = _diceScorer.ScoreOnes(diceToScore);

            Assert.AreEqual(1000, actualScore);
        }
    }
}
