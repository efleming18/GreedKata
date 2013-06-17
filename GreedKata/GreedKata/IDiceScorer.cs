using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreFives(List<int> list);

        int ScoreOnes(List<int> list);
    }
}