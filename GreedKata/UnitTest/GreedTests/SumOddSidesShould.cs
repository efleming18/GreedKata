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

        [Test]
        public void Given50PointsFromFivesAndZeroPointsFromThreeAndOnesThenScore50Points()
        {
            var expectedPoints = 50;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(50);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Give300PointsFromThreesAndZeroPointsFromOnesAndFivesThenScore300Points()
        {
            var expectedPoints = 300;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(300);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Given100PointsFromOnesAndZeroPointsFromFivesAndThreesScore300Points()
        {
            var expectedPoints = 100;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(100);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void Given100PointsFromOnesAndFiftyPointsFromFivesAnd300PointsFromThreesScore450Points()
        {
            var expectedPoints = 450;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(100);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(300);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(50);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void GivenZeroPointsFromOnesThreesAndFivesThenScoreZeroPoints()
        {
            var expectedPoints = 0;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(0);
            _mockedDiceScorer.Setup(mds => mds.ScoreThrees(_dice)).Returns(0);

            var actualPoints = _greed.SumOddSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
