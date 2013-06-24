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

        //Do you think we should write all of the acceptance tests for the entire feature?
        //Yes! I do think so. The only thing is that maybe we have too much going on?
        //I like the ATDD style but I also like just the TDD style. I think just having ATDD style would cover both but since we have alot from the TDD we started 
        //it may be difficult to kind of split them apart? I just feel too repetitive with the tests.

        //That would probably avoid overlooking test cases since we would still have failing tests.
        //However, we might lose a bit of focus since we don't have one clear acceptance test to make pass.

        //Or do you not like the acceptance tests? You seems to be forgetting about them here
        //but you seem to like them with the javaScript. My guess was that you are just running tests from
        //Haha I honestly didn't even notice we had them. For some reason the shortcut for RUN ALL TESTS wasn't getting the Acceptance tests as well. Sorry about that!
        [Test]
        [TestCaseSource("diceRollsWithMoreThanThreeThrees")]
        public void GivenMoreThanThreeThrees_WhenDiceAreRolled_ReturnThreeHundredPoints(List<int> diceToScore)
        {
            var actualScore = _diceScorer.ScoreThrees(diceToScore);

            Assert.AreEqual(300, actualScore);
        }
    }
}
