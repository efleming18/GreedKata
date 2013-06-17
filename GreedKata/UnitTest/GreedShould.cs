using System;
using System.Collections.Generic;
using GreedKata;
using Moq;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class GreedShould
    {
        private Mock<IDiceScorer> _mockedDiceScorer;
        private Greed _greed;
        private List<int> _dice;

        [SetUp]
        public void SetUp()
        {
            _mockedDiceScorer = new Mock<IDiceScorer>();
            _greed = new Greed(_mockedDiceScorer.Object);
            _dice = new List<int> { 1, 0, 0, 0, 0 };
        }

        [Test]
        public void ReturnOneHundredPointsIfASingleOneIsScored()
        {
            var expectedPoints = 100;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(100);

            var actualPoints = _greed.GetTotalPoints(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        //Should this test be moved? And the rest of the tests moved/renamed to show that they are testing the mocks and not actual code? Thoughts?
        [Test]
        public void ReturnFiftyPointsIfASingleFiveIsScored()
        {
            var expectedPoints = 50;

            var actualPoints = _greed.GetTotalPoints(new List<int> { 2, 2, 3, 4, 5 });

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneThousandPointsIfTripleOnesIsScored()
        {
            var expectedPoints = 1000;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(1000);

            var actualPoints = _greed.GetTotalPoints(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneThousandAndFiftyWhenThreeOnesAndOneFiveIsRolled()
        {
            var expectedPoints = 1050;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(1000);
            //WHY WON'T THIS FREAKING LINE WORK!??!?!?!? FIX IT RICH!!
            _mockedDiceScorer.Setup(mds => mds.ScoreFives(_dice)).Returns(50);

            var actualPoints = _greed.GetTotalPoints(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnTwoHundreIfTripleTwosIsScored()
        {
            var expectedPoints = 200;

            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(_dice)).Returns(1050);

            var actualPoints = _greed.GetTotalPoints(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
