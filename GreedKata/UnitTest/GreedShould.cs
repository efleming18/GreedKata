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
        [Test]
        public void ReturnOneHundredPointsIfASingleOneIsScored()
        {
            var greed = new Greed();
            var expectedPoints = 100;

            var actualPoints = greed.GetTotalPoints(new List<int> {1, 2, 3, 4, 5});

            Assert.AreEqual(expectedPoints, actualPoints);
        }

        //public IEnumerable<TestCaseData> DiceResultsWithThreeOrMoreSixes
        //{
        //    get
        //    {
        //        yield return new TestCaseData(new List<int>{6,6,6,6,6});
        //        yield return new TestCaseData(new List<int>{6,6,6,6,2});
        //        yield return new TestCaseData(new List<int>{6,6,5,6,4});
        //        yield return new TestCaseData(new List<int>{6,3,6,6,6});
        //        yield return new TestCaseData(new List<int>{6,2,4,6,6});
        //    }
        //}

        //// If you can fix this on your refactor please do so!
        //// I wanted to use test case, but it seemed unhappy with me.
        //[TestCaseSource("DiceResultsWithThreeOrMoreSixes")]
        //public void Gain600PointsFromThreeOrMoreSixes(List<int> diceRollResults)
        //{
        //    var greed = new Greed();
        //    var expectedPoints = 600;

        //    var actualPoints = greed.GetPointsFromSixes(diceRollResults);

        //    Assert.AreEqual(expectedPoints, actualPoints);

        //}
    }
}
