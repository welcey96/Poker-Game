namespace BOLayer
{
    public static class PokerEvaluator
    {
        public const int TOP_CARD_COUNT = 5 ;
        public static Combination EvaluateTopCombination(Hand hand)
        {
            List<Card> allCards = SortHandByRank(hand);

            bool isFlush = false;
            List<Card> filteredCards = GroupBySuit(allCards);

            if (IsFlush(filteredCards))
            {
                if (IsRoyalFlush(filteredCards))
                    return Combination.RoyalFlush;
                if (IsStraight(filteredCards))
                    return Combination.StraightFlush;

                isFlush = true;
            }

            if (IsFourOfAKind(allCards))
                return Combination.FourOfAKind;
            if (IsFullHouse(allCards))
                return Combination.FullHouse;

            if (isFlush)
                return Combination.Flush;

            if (IsStraight(allCards))
                return Combination.Straight;

            if (IsThreeOfAKind(allCards))
                return Combination.ThreeOfAKind;

            return ValidatePairs(allCards);
        }
        public static Hand GetTopCards(Combination combination, Hand hand)
        {
            List<Card> allCards = SortHandByRank(hand);

            switch (combination)
            {
                case Combination.RoyalFlush:
                case Combination.Flush:
                case Combination.HighCard:
                    allCards = (combination == Combination.HighCard ?
                                allCards : GroupBySuit(allCards))
                               .OrderByDescending(c => c.FaceValue)
                               .Take(TOP_CARD_COUNT)
                               .ToList();
                    break;

                case Combination.StraightFlush:
                case Combination.Straight:

                    allCards = GetStraightCards(combination == Combination.StraightFlush ?
                               GroupBySuit(allCards) : allCards);
                    break;

                case Combination.FourOfAKind:
                case Combination.FullHouse:
                case Combination.ThreeOfAKind:

                    Dictionary<FaceValue, List<Card>> _groupBy = allCards
                       .GroupBy(c => c.FaceValue)
                       .Select(g => new KeyValuePair<FaceValue, List<Card>>(g.Key, g.ToList()))
                       .ToDictionary();

                    allCards = (combination == Combination.FourOfAKind ? _groupBy
                        .OrderByDescending(g => g.Value.Count == 4) : _groupBy
                        .OrderByDescending(g => g.Value.Count))
                        .ThenByDescending(g => g.Key)
                        .ToDictionary()
                        .Values
                        .SelectMany(v => v)
                        .Take(TOP_CARD_COUNT)
                        .ToList();

                    break;

                case Combination.TwoPair:
                case Combination.Pair:

                    Dictionary<FaceValue, List<Card>> pairs = allCards
                               .GroupBy(c => c.FaceValue)
                               .Select(g => new KeyValuePair<FaceValue, List<Card>>(g.Key, g.ToList()))
                               .OrderByDescending(g => g.Value.Count)
                               .ThenByDescending(g => g.Key)
                               .ToDictionary();

                    int count = pairs.Count(kv => kv.Value.Count == 2);
                    if (count >= 1)
                    {
                        count = count >= 2 ? 2 : 1;
                        allCards = pairs.Take(count).SelectMany(g => g.Value).ToList();

                        allCards.AddRange(pairs
                            .Skip(count)
                            .OrderByDescending(g => g.Key)
                            .SelectMany(v => v.Value)
                            .Take(count == 2 ? 1 : 3));
                    }
                    break;
            }

            if (allCards.Count != TOP_CARD_COUNT)
                throw new InvalidOperationException("Invalid card combination");

            Hand topHand = new();
            topHand.AddCard(allCards);

            return topHand;
        }
        private static bool IsRoyalFlush(List<Card> hand)
        {
            int cardCount = 0;
            foreach (FaceValue item in new List<FaceValue>() { FaceValue.Ten, FaceValue.Jack, FaceValue.Queen, FaceValue.King, FaceValue.Ace })
            {
                if (hand.FirstOrDefault(c => c.FaceValue == item) != null)
                    cardCount++;

                if (cardCount == TOP_CARD_COUNT) return true;
            }

            return false;
        }
        private static bool IsFourOfAKind(List<Card> hand)
        {
            return GroupByRank(hand, 4).Count == 4;
        }
        private static bool IsFullHouse(List<Card> hand)
        {
            int groupCount = hand
                .GroupBy(c => c.FaceValue)
                .Count(g => g.Count() == 3);


            if (groupCount >= 1)
            {
                if (groupCount == 2) return true;

                return hand
                    .GroupBy(c => c.FaceValue)
                    .Count(g => g.Count() == 2) >= 1;
            }

            return false;
        }
        private static bool IsFlush(List<Card> hand)
        {
            return hand.Count >= TOP_CARD_COUNT;
        }
        private static bool IsStraight(List<Card> hand)
        {
            int sequenceCount = 1;
            int lastRankInSequence = 1;

            for (int i = 0; i < hand.Count - 1; i++)
            {
                if (hand[i].FaceValue + 1 == hand[i + 1].FaceValue)
                {
                    lastRankInSequence = (int)hand[i + 1].FaceValue;
                    sequenceCount++;
                    if (sequenceCount == TOP_CARD_COUNT)
                        return true;
                }
                else
                {
                    if (sequenceCount == 4 &&
                        lastRankInSequence == (int)FaceValue.Five &&
                        hand.FirstOrDefault(c => c.FaceValue == FaceValue.Ace) != null)
                        return true;
                    else
                        sequenceCount = 1;
                }
            }

            return false;
        }
        private static bool IsThreeOfAKind(List<Card> hand)
        {
            return GroupByRank(hand, 3).Count == 3;
        }
        private static Combination ValidatePairs(List<Card> hand)
        {
            int groupCount = hand
                 .GroupBy(card => card.FaceValue)
                 .Count(group => group.Count() == 2);
            if (groupCount >= 1)
                return groupCount >= 2 ? Combination.TwoPair : Combination.Pair;
            return Combination.HighCard;
        }
        private static List<Card> GroupBySuit(List<Card> hand)
        {
            return hand
                .GroupBy(c => c.Suit)
                .Where(g => g.Count() >= TOP_CARD_COUNT)
                .SelectMany(g => g)
                .ToList();
        }
        private static List<Card> GroupByRank(List<Card> hand, int count)
        {
            return hand
                .GroupBy(c => c.FaceValue)
                .Where(g => g.Count() == count)
                .SelectMany(g => g)
                .ToList();
        }
        private static List<Card> GetStraightCards(List<Card> hand)
        {
            List<Card> topFiveCards = new() { hand[hand.Count - 1] };
            Card? ace = hand.FirstOrDefault(c => c.FaceValue == FaceValue.Ace);

            for (int i = hand.Count - 1; i >= 0; i--)
            {
                if (i - 1 >= 0 && hand[i].FaceValue - 1 == hand[i - 1].FaceValue)
                {
                    topFiveCards.Add(hand[i - 1]);

                    if (topFiveCards.Count == TOP_CARD_COUNT)
                        break;
                }
                else
                {
                    if (topFiveCards.Count == 4 &&
                        topFiveCards.LastOrDefault()!.FaceValue == FaceValue.Two &&
                        ace != null)
                    {
                        topFiveCards.Add(ace);
                        break;
                    }
                    else
                    {
                        topFiveCards = new();
                        if (i - 1 >= 0)
                            topFiveCards.Add(hand[i - 1]);
                        else
                            break;
                    }
                }
            }

            return topFiveCards;
        }
        private static List<Card> SortHandByRank(Hand hand)
        {
            List<Card> allCards = new(hand.GetCards());
            allCards.Sort((a, b) => a.FaceValue.CompareTo(b.FaceValue));
            return allCards;
        }

    }
}
