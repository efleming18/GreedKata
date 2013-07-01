using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using NUnit.Framework;

namespace UnitTest.DiceScorerTests
{
    [TestFixture]
    class ScoreStraightShould
    {
        //So I am thinking for our naming convention that I like the way we have it for Features.
        //But for unit tests I like the name "ScoreStraightShould" for the name of the file
        //Then the method names to be "ReturnWhateverValue".
        //Thoughts? I am open to discussion on this one!
        //By the way I wrote my article, are we going to set up a repo for articles or how should we manage them?
        [Test]
        public void ReturnTwelveHundredPoints()
        {
            var diceToScore = new List<int> { 1, 2, 3, 4, 5, 6 };
            var diceScorer = new DiceScorer();

            var actualValue = diceScorer.ScoreStraight(diceToScore);

            Assert.AreEqual(1200, actualValue);
        }
    }
}
