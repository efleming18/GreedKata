using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreOnes(List<int> diceRoll);
        int ScoreThrees();

        int ScoreSixes();
        int ScoreFours();
        int ScoreTwos();
        int ScoreFives();
        int ScoreOnes();
    }
}