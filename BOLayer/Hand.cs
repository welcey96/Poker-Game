namespace BOLayer
{
    public class Hand
    {
        private List<Card> cards = new();
        public int Count { get => cards.Count; }
        public Card this[int index] { get => cards[index]; }

        #region Methods
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public void AddCard(List<Card> cards)
        {
            cards.ForEach(c => AddCard(c));
        }
        public List<Card> GetCards() => cards;
        #endregion
    }
}
