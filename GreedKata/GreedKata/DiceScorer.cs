using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        private readonly List<int> _diceToScore;
        

        public DiceScorer()
        { }

        //yeah, I don't like passing this into the constructor anymore.
        //That was dumbe.. boo me! :p (ps, twitter gem in there for ya)
        public DiceScorer(List<int> diceToScore)
        {
            _diceToScore = diceToScore;
        }

        public int ScoreOnes(List<int> diceRoll)
        {
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