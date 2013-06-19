using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        private readonly IDiceScorer _diceScorer;

        public Greed(IDiceScorer diceScorer)
        {
            _diceScorer = diceScorer;
        }

        public int GetTotalPoints(List<int> diceRoll)
        {
            throw new NotImplementedException();
        }

        public int SumEvenSides(List<int> diceRoll)
        {
            var sum = _diceScorer.ScoreFours();
            return sum += _diceScorer.ScoreTwos();
        }

        public int SumOddSides(List<int> diceRoll) 
        {
            var sum = _diceScorer.ScoreOnes();
            sum += _diceScorer.ScoreThrees();
            return sum + _diceScorer.ScoreFives();
        }
    }
}
