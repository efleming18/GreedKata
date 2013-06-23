using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreFives(List<int> _diceRoll);

        int ScoreTwos(List<int> _diceRoll);

        int ScoreSixes(List<int> _diceRoll);

        int ScoreFours(List<int> _diceRoll);

        int ScoreOnes(List<int> diceRoll);

        int ScoreThrees(List<int> diceRoll);
    }
}