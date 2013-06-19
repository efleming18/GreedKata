using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        private readonly List<int> _diceToScore;

        public DiceScorer(List<int> _diceToScore)
        {
            _diceToScore = _diceToScore;
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
            throw new NotImplementedException();
        }
        
    }
}