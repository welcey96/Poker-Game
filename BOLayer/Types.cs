namespace BOLayer
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum FaceValue
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Combination
    {
        HighCard,
        Pair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush
    }

    public enum Stage
    {
        PreFlop,
        Flop,
        Turn,
        River
    }
    public enum PlayerType
    {
        Bot,
        Human
    }
    public enum PlayerAction
    {
        FOLD,
        CHECK,
        CALL,
        RAISE
    }
}
