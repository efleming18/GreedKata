using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        public int GetTotalPoints(List<int> diceRoll)
        {
            if (diceRoll.Contains(1))
            {
                return 100;
            }
            return 50;
        }
    }
}
