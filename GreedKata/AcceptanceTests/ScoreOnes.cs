using System;
using System.Collections.Generic;
using GreedKata;
using NUnit.Framework;

namespace AcceptanceTests
{
    [TestFixture]
    public class ScoreOnes
    {
        //This could probably use a better name/be moved to another file?
        //Yes :)
        [Test]
        public void GivenOneOne_WhenDiceAreRolled_ThenReturnOneHundredPoints()
        {
            var expectedPoints = 100;
            var testRoll = new List<int> { 1, 0, 0, 0, 0 };
            var greed = new Greed();

            var actualPoints = greed.GetTotalPoints(testRoll);

            Assert.AreEqual(expectedPoints, actualPoints);
        }

    }
}
