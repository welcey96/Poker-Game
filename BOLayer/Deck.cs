using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Deck
    {
        private List<Card> deck = new();
        private Random rand = new();

        public Deck()
        {
            MakeDeck();
        }

        #region Methods
        public Hand DealHand(int number)
        {
            if (deck.Count == 0)
                throw new InvalidOperationException("No cards left in the deck");

            Hand hand = new Hand();
            int numCardsToDeal = number;

            if (deck.Count < numCardsToDeal)
            {
                numCardsToDeal = deck.Count;
            }

            while (numCardsToDeal > 0)
            {
                hand.AddCard(DrawOneCard());
                numCardsToDeal--;
            }

            return hand;
        }
        public Card DrawOneCard()
        {
            if (deck.Count == 0)
                throw new InvalidOperationException("No cards left in the deck");

            Card topCard = deck[0];
            deck.RemoveAt(0);

            return topCard;
        }
        private void MakeDeck()
        {
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue r in Enum.GetValues(typeof(FaceValue)))
                {
                    deck.Add(new Card(s, r));
                }
            }
        }
        public void Shuffle()
        {
            int numCards = deck.Count;

            while (numCards > 1)
            {
                numCards--;
                int randomIndex = rand.Next(numCards + 1);
                Card temp = deck[randomIndex];
                deck[randomIndex] = deck[numCards];
                deck[numCards] = temp;
            }

        }
        #endregion

    }
}
