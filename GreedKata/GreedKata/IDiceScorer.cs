using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreSixes();

        int ScoreFours();

        int ScoreThrees();

        int ScoreTwos();
        int ScoreFives();
        int ScoreOnes();
    }
}