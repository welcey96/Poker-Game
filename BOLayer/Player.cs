using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Player
    {
        private decimal chips = 150;
        public string Name { get; set; } = "PLAYER";
        public Hand Hand { get; set; } = new();
        public decimal Chips
        {
            get => chips;
            private set
            {
                chips = value < 0 ? 0 : value;
            }
        }
        public PlayerType Type { get; set; }
        public bool IsBigBlind { get; set; } 
        public bool IsSmallBlind { get; set; } 
        public bool IsFolded { get; set; }
        public Combination CardCombination { get; set; } = Combination.HighCard;

        public void DeductChips(decimal betAmount)
        {
            Chips -= betAmount;
        }

        public void AddChips(decimal amount)
        {
            Chips += amount;
        }

    }
}
