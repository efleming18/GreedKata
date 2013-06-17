using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreOnes(List<int> list);
        int ScoreFives(List<int> list);
    }
}