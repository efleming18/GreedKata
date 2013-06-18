using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        int ScoreTwos(List<int> list);

        int ScoreFives(List<int> list);

        int ScoreOnes(List<int> list);
    }
}