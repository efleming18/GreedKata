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

        [SetUp]
        public void SetUp()
        {
            _mockedDiceScorer = new Mock<IDiceScorer>();
            _greed = new Greed(_mockedDiceScorer.Object);
        }

        [Test]
        public void ReturnOneHundredPointsIfASingleOneIsScored()
        {
            var hasOneOne = new List<int> { 1, 2, 3, 4, 5 };
            var expectedPoints = 100;

            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(hasOneOne)).Returns(100);
            
            var actualPoints = _greed.GetTotalPoints(hasOneOne);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnFiftyPointsIfASingleFiveIsScored()
        {
            var greed = new Greed(null);
            var expectedPoints = 50;

            var actualPoints = greed.GetTotalPoints(new List<int> { 2, 2, 3, 4, 5 });

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnOneThousandPointsIfTripleOnesIsScored()
        {
            var hasThreeOnes = new List<int> { 1, 1, 1, 2, 3 };
            var expectedPoints = 1000;

            _mockedDiceScorer.Setup(mds => mds.ScoreOnes(hasThreeOnes)).Returns(1000);

            var actualPoints = _greed.GetTotalPoints(hasThreeOnes);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        //Awesome! Should we make a "Comments" .txt file to keep a log of everything we talk about or just keep doing it this way?
        //I like it this way. The log would lack context.
    }
}
