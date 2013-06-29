using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        private readonly int _sizeOFSet = 3;

        public int ScoreOnes(List<int> diceRoll)
        {
            var extraMultiplyerForOnes = 10;
            var total = StandardScoring(diceRoll, 1) * extraMultiplyerForOnes;
            total += SingleDiceScoring(diceRoll, 1) * extraMultiplyerForOnes;
            return total;
        }

        public int ScoreThrees(List<int> diceRoll)
        {
            return StandardScoring(diceRoll, 3);
        }

        public int ScoreFives(List<int> diceRoll)
        {
            var total = StandardScoring(diceRoll, 5);
            total += SingleDiceScoring(diceRoll, 5);
            return total;
        }

        public int ScoreTwos(List<int> diceRoll)
        {
            var standardScoringScore = StandardScoring(diceRoll, 2);
            return standardScoringScore * 2;
            //return StandardScoring(diceRoll, 2);
        }

        public int ScoreFours(List<int> diceRoll)
        {
            return StandardScoring(diceRoll, 4);
        } 

        public int ScoreSixes(List<int> diceRoll)
        {
            return StandardScoring(diceRoll, 6);
        }   
    
        
        
        private int StandardScoring(List<int> diceRoll, int sideToScore)
        {
            int numberOfTimesSideWasRolled = diceRoll.Count(die => die == sideToScore);
            int setsOfThree = numberOfTimesSideWasRolled / _sizeOFSet;
            return setsOfThree * sideToScore * 100;
        }

        private int SingleDiceScoring(List<int> diceRoll, int sideToScore)
        {
            int numberOfTimesSideWasRolled = diceRoll.Count(die => die == sideToScore);
            int numberOfSingleDiceToScore = numberOfTimesSideWasRolled % _sizeOFSet;
            return numberOfSingleDiceToScore * sideToScore * 10;
        }
    }
}