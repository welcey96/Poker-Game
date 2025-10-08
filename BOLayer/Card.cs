using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Card
    {
        public Suit Suit { get; set; }
        public FaceValue FaceValue { get; set; }
        public Card(Suit suit, FaceValue newValue)
        {
            Suit = suit;
            FaceValue = newValue;
        }
    }
}
