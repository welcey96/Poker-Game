using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public static class Utilities
    {
        public static string TransformBettingStage(int stageNum)
        {
            switch (stageNum)
            {
                case (int)Stage.PreFlop:
                    return "PRE FLOP";
                case (int)Stage.Flop:
                    return "FLOP";
                case (int)Stage.Turn:
                    return "TURN";
                case (int)Stage.River:
                    return "RIVER";
                case (int)Stage.River + 1:
                    return "SHOW DOWN";
                default:
                    return "";
            }
        }
        public static string TransfomCombination(Combination combination)
        {
            switch (combination)
            {
                case Combination.RoyalFlush:
                    return "ROYAL FLUSH";
                case Combination.StraightFlush:
                    return "STRAIGHT FLUSH";
                case Combination.FourOfAKind:
                    return "FOUR OF A KIND";
                case Combination.FullHouse:
                    return "FULL HOUSE";
                case Combination.Flush:
                    return "FLUSH";
                case Combination.Straight:
                    return "STRAIGHT";
                case Combination.ThreeOfAKind:
                    return "THREE OF A KIND";
                case Combination.TwoPair:
                    return "TWO PAIR";
                case Combination.Pair:
                    return "PAIR";
                case Combination.HighCard:
                    return "HIGH CARD";
                default:
                    return "";
            }
        }
    }
}
