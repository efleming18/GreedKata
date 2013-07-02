using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class DiceScorer : IDiceScorer
    {
        private readonly int _sizeOFSet = 3;

        public object ScoreStraight(List<int> diceRoll)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int ScoreThreePairs(List<int> diceRoll)
        {
            // Sorry for the late check in!
            // I will read your ATTD post tomorrow morning when I come in :)
            var pairs = 0;
            foreach (var dieSide in diceRoll.Distinct())
	        {
                int dieSideCount = diceRoll.Count(die => die == dieSide);
                if (dieSideCount >= 2) 
                {
                    pairs++;
                }
	        }
            return (pairs >= 3) ? 800 : 0;
        }

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
            var numberOfTwosRolled = diceRoll.Count(die => die == 2);
            var totalScore = StandardScoring(diceRoll, 2);
            if (numberOfTwosRolled > 3)
            {
                totalScore = totalScore * 2;
            }
            if (numberOfTwosRolled > 4)
            {
                totalScore = totalScore * 2;
            }
            return totalScore;
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