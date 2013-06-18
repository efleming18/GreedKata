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
        [Test]
        public void ReturnFiftyPointsFromFivesZeroPointsFromOnesAndZeroPointsFromThrees()
        {
            var expectedPoints = 50;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(50);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Given300PointsFromThrees0PointsFromOnes0PointsFromFivesThenReturn300Points()
        {
            var expectedPoints = 300;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(300);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneHundredPointsFromOnesZeroPointsFromFivesAndZeroPointsFromThrees()
        {
            var expectedPoints = 100;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(100);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneThousandPointsFromOnesZeroPointsFromFivesAndZeroPointsFromThrees()
        {
            var expectedPoints = 1000;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(1000);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneThousandFromOnesFiftyFromFivesAndZeroFromThree()
        {
            var expectedPoints = 1050;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(1000);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(50);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
