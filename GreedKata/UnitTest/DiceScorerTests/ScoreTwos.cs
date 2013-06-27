﻿using System;
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

        private static List<int>[] diceRollsWithMoreThanThreeTwos = { 
            new List<int> { 2, 2, 2, 2 }, 
            new List<int> { 2, 2, 2, 2, 2 }
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
        [TestCaseSource("diceRollsWithMoreThanThreeTwos")]
        public void GivenMoreThanThreeTwos_ThenReturnTwoHundredPoints(List<int> diceRoll)
        {
            var diceScorer = new DiceScorer();

            var actualPoints = diceScorer.ScoreTwos(diceRoll);

            Assert.AreEqual(200, actualPoints);
        }
    }
}
