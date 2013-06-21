using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreOnes(List<int> diceRoll);

        int ScoreSixes();

        int ScoreFours();

        int ScoreThrees();

        int ScoreTwos();
        int ScoreFives();
        int ScoreOnes();
    }
}