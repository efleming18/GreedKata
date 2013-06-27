using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        //Functions used in SumOddSides
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
            var numberOfThrees = diceRoll.Count(dr => dr == 3);
            var total = 0;
            if (numberOfThrees >= 3)
            {
                total = 300;
            }
            return total;
        }

        public int ScoreFives(List<int> _diceRoll)
        {
            var numberOfFives = _diceRoll.Count(dr => dr == 5);
            var total = 0;
            if (numberOfFives < 3)
            {
                total = numberOfFives * 50;
            }
            if (numberOfFives >= 3)
            {
                numberOfFives = numberOfFives - 3;
                total = 500 + (numberOfFives * 50);
            }
            return total;
        }

        public int ScoreTwos(List<int> _diceRoll)
        {
            var numberOfTwos = _diceRoll.Count(dr => dr == 2);
            if (numberOfTwos == 3)
            {
                return 200;
            }
            return 0;
        }

        public int ScoreFours(List<int> _diceRoll)
        {
            return 0;
        } 

        public int ScoreSixes(List<int> _diceRoll)
        {
            return 0;
        }       
    }
}