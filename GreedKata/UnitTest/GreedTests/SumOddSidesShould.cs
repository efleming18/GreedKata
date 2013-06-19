using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using Moq;
using NUnit.Framework;

namespace UnitTest.GreedTests
{
    [TestFixture]
    class SumOddSidesShould
    {
        private Mock<IDiceScorer> _mockedDiceScorer;
        private Greed _greed;
        private List<int> _dice;

        [SetUp]
        public void SetUp()
        {
            _mockedDiceScorer = new Mock<IDiceScorer>();
            _greed = new Greed(_mockedDiceScorer.Object);
            _dice = new List<int> { 0, 0, 0, 0, 0 };
        }

        //If scoring changes so that a single five now returns 75 points, this test would still pass but would be incorrect.
        //So it should be closer to: 
                //Given-FiftyPointsFromFivesAndZeroPointsFromOnes
                //When-DiceAreRolled
                //Then-ReturnFiftyPoints
        //Mind hitting the names with your next refactor?

        //Hmm....these names are extremely long! Any way around this? Also, are the current names what you were after?
        //I added in the mock for the ScoreThree method since this class is testing the SumOddSides (1, 3, and 5). Is this what you're thinking is right too?

        // Yes, and not really, which is why I used 300 instead of threehundered even though I like writing the word better.m
        // I do wish we could break up the method name onto multiple lines.

        //That would be nice! Oh well, long names that fully describe our test are better than short obscure names I guess :)
        [Test]
        public void Given50PointsFromFivesAndZeroPointsFromThreeAndOnesThenScore50Points()
        {
            var expectedPoints = 50;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes()).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives()).Returns(50);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees()).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Give300PointsFromThreesAndZeroPointsFromOnesAndFivesThenScore300Points()
        {
            var expectedPoints = 300;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes()).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees()).Returns(300);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives()).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Given100PointsFromOnesAndZeroPointsFromFivesAndThreesScore300Points()
        {
            var expectedPoints = 100;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes()).Returns(100);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives()).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees()).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Given100PointsFromOnesAndFiftyPointsFromFivesAnd300PointsFromThreesScore450Points()
        {
            var expectedPoints = 450;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes()).Returns(100);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives()).Returns(300);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees()).Returns(50);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenZeroPointsFromOnesThreesAndFivesThenScoreZeroPoints()
        {
            var expectedPoints = 0;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes()).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives()).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees()).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
