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
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(new List<int> { 1, 1, 1, 0, 0 })).Returns(1000);

            var actualPoints = _greed.GetTotalPoints(new List<int> { 1, 1, 1, 0, 0});

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        //Awesome! Should we make a "Comments" .txt file to keep a log of everything we talk about or just keep doing it this way?
        //I like it this way. The log would probably lack too much context.
        //Agreed!
        [Test]
        public void ReturnOneThousandAndFiftyWhenThreeOnesAndOneFiveIsRolled()
        {
            var expectedPoints = 1050;
            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(new List<int> { 1, 1, 1, 5, 2 })).Returns(1050);

            var actualPoints = _greed.GetTotalPoints(new List<int> { 1, 1, 1, 5, 2 });

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
