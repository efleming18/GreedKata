using System;
using System.Collections.Generic;
using GreedKata;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class GreedShould
    {
        //Hey Rich, I think we need to start much smaller on this kata. Start with the most simple outcome/instruction and work our way up.
        //I think jumping in to actually counting a the 6's values would be moving too quick.
        //What are your thought

        // Works for me!
        [Test]
        public void ReturnOneHundredPointsIfASingleOneIsScored()
        {
            var greed = new Greed();
            var expectedPoints = 100;

            var actualPoints = greed.GetTotalPoints(new List<int> {1, 2, 3, 4, 5});

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
