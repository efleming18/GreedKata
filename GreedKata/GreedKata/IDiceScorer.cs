using System.Collections.Generic;

namespace GreedKata
{
    public interface IDiceScorer
    {
        //The "list" that these methods take in could use a better name I think! Something for your refactor step :)

        int ScoreFours(List<int> list);

        int ScoreThrees(List<int> list);

        int ScoreTwos(List<int> list);

        int ScoreFives(List<int> list);

        int ScoreOnes(List<int> list);
    }
}