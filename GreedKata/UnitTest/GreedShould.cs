using System;
using System.Collections.Generic;
using GreedKata;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class GreedShould
    {
        public IEnumerable<TestCaseData> DiceResultsWithThreeOrMoreSixes
        {
            get
            {
                yield return new TestCaseData(new List<int>{6,6,6,6,6});
                yield return new TestCaseData(new List<int>{6,6,6,6,2});
                yield return new TestCaseData(new List<int>{6,6,5,6,4});
                yield return new TestCaseData(new List<int>{6,3,6,6,6});
                yield return new TestCaseData(new List<int>{6,2,4,6,6});
            }
        }

        // If you can fix this on your refactor please do so!
        // I wanted to use test case, but it seemed unhappy with me.
        [TestCaseSource("DiceResultsWithThreeOrMoreSixes")]
        public void Gain600PointsFromThreeOrMoreSixes(List<int> diceRollResults)
        {
            var greed = new Greed();
            var expectedPoints = 600;

            var actualPoints = greed.GetPointsFromSixes(diceRollResults);

            Assert.AreEqual(expectedPoints, actualPoints);

        }
    }
}
