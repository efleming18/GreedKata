using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        public int ScoreOnes(List<int> diceRoll)
        {
            var numberOfOnes = diceRoll.Count(dr => dr == 1);
            if (numberOfOnes > 2) 
            {
                numberOfOnes = (numberOfOnes - 3);
                return 1000 + (numberOfOnes * 100); 
            }
            return numberOfOnes * 100;
        }

        public int ScoreThrees(List<int> diceRoll)
        {
            return 0;
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