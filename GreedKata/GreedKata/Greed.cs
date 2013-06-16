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
            if (diceRoll.Contains(1))
            {
                return _diceScorer.ScoreOnes(diceRoll);
            }
            return 50;
        }
    }
}
