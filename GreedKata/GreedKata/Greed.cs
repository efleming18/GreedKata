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
            var sum = 0;
            sum += _diceScorer.ScoreOnes(diceRoll);
            sum += _diceScorer.ScoreTwos(diceRoll);
            sum += _diceScorer.ScoreFives(diceRoll);
            return sum;
        }
    }
}
