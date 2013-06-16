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
        //Awesome! Should we make a "Comments" .txt file to keep a log of everything we talk about or just keep doing it this way?
        [Test]
        public void ReturnOneHundredPointsIfASingleOneIsScored()
        {
            var greed = new Greed();
            var expectedPoints = 100;

            var actualPoints = greed.GetTotalPoints(new List<int> {1, 2, 3, 4, 5});

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [Test]
        public void ReturnFiftyPointsIfASingleFiveIsScored()
        {
            var greed = new Greed();
            var expectedPoints = 50;

            var actualPoints = greed.GetTotalPoints(new List<int> { 2, 2, 3, 4, 5 });

            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
