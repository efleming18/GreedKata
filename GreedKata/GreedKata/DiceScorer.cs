using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        public int ScoreOnes(List<int> diceRoll)
        {
            if (diceRoll.Count(die => die == 1) > 2) { return 1000; }
            var numberOfOnes = diceRoll.Count(dr => dr == 1);
            return numberOfOnes * 100;
        }

        public int ScoreFours()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreThrees()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreTwos()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreFives()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreOnes()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreSixes()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
        
    }
}