using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests.SumOddSidesCompleteFeature
{
    [TestFixture]
    class SumOddSidesFeature
    {
        [Test]
        public void GivenOneThreeFive_WhenRolled_ReturnOneHundredFifty()
        {
            var diceToScore = new List<int> { 1, 3, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);
            var actualValue = greed.SumOddSides(diceToScore);

            Assert.AreEqual(150, actualValue);
        }

        [Test]
        public void GivenThreeOnesAndOneFive_WhenRolled_ReturnElevenHundred()
        {
            var diceToScore = new List<int> { 1, 1, 1, 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);
            var actualValue = greed.SumOddSides(diceToScore);

            Assert.AreEqual(1100, actualValue);
        }

        [Test]
        public void GivenThreeFivesAndTwoOnes_WhenRolled_ReturnSevenHundred()
        {
            var diceToScore = new List<int> { 1, 1, 5, 5, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);
            var actualValue = greed.SumOddSides(diceToScore);

            Assert.AreEqual(700, actualValue);
        }

        [Test]
        public void GivenThreeThreesOneOneAndOneFive_WhenRolled_ReturnFourHundredFifty()
        {
            var diceToScore = new List<int> { 3, 3, 3, 1, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);
            var actualValue = greed.SumOddSides(diceToScore);

            Assert.AreEqual(450, actualValue);
        }

        //You can add more if you'd like but I think we get the picture :)
        [Test]
        public void GivenFourOnesAndOneFive_WhenRolled_ReturnElevenHundredFifty()
        {
            var diceToScore = new List<int> { 1, 1, 1, 1, 5 };
            var diceScorer = new DiceScorer();
            var greed = new Greed(diceScorer);
            var actualValue = greed.SumOddSides(diceToScore);

            Assert.AreEqual(1150, actualValue);
        }
    }
}
