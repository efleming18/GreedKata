using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        public int ScoreOnes(List<int> list)
        {
            var numberOfOnes = list.Where(o => o.Equals(1)).Count();
            if (numberOfOnes == 3)
            {
                return 1000;
            }
            return 100;
        }

        public int ScoreFives(List<int> list)
        {
            return 50;
        }
    }
}