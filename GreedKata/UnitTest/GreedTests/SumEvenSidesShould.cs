using System;
using System.Collections.Generic;
using System.Linq;
using GreedKata;
using Moq;
using NUnit.Framework;

namespace UnitTest.GreedTests
{
    [TestFixture]
    class SumEvenSidesShould
    {
        private Mock<IDiceScorer> _mockDiceScorer;
        private Greed _greed;
        private List<int> _dice;

        [SetUp]
        public void SetUp()
        {
            _mockDiceScorer = new Mock<IDiceScorer>();
            _greed = new Greed(_mockDiceScorer.Object);
            _dice = new List<int> { 0, 0, 0, 0, 0 };
        }

        [Test]
        public void ReturnTwoHundreIfTripleTwosIsScored()
        {
            var expectedPoints = 200;
            _mockDiceScorer.Setup(mds => mds.ScoreTwos()).Returns(200);

            var actualPoints = _greed.SumEvenSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnFourHundredFromZeroTwosAndThreeFours()
        {
            var expectedPoints = 400;
            _mockDiceScorer.Setup(mds => mds.ScoreTwos()).Returns(0);
            _mockDiceScorer.Setup(mds => mds.ScoreFours()).Returns(400);

            var actualPoints = _greed.SumEvenSides(_dice);

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
