﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        private readonly IDiceScorer _diceScorer;

        public Greed(IDiceScorer diceScorer)
        {
            _diceScorer = diceScorer;
        }

        public int GetTotalPoints(List<int> diceRoll)
        {
            return _diceScorer.ScoreOnes(diceRoll);
        }

        public int SumEvenSides(List<int> diceRoll)
        {
            var sum = _diceScorer.ScoreFours();
            sum += _diceScorer.ScoreSixes();
            return sum += _diceScorer.ScoreTwos();
        }

        public int SumOddSides(List<int> diceRoll) 
        {
            var sum = _diceScorer.ScoreOnes();
            sum += _diceScorer.ScoreThrees();
            return sum + _diceScorer.ScoreFives();
        }
    }
}
