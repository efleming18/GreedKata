using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreThreePairs(List<int> diceRoll);
        
        int ScoreFives(List<int> diceRoll);

        int ScoreTwos(List<int> diceRoll);

        int ScoreSixes(List<int> diceRoll);

        int ScoreFours(List<int> diceRoll);

        int ScoreOnes(List<int> diceRoll);

        int ScoreThrees(List<int> diceRoll);
    }
}