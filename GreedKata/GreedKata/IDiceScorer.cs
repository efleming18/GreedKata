using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreFours();
        int ScoreThrees();
        int ScoreTwos();
        int ScoreFives();
        int ScoreOnes();
    }
}