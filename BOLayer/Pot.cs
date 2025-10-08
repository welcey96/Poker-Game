using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Pot
    {
        public Pot(decimal smallBlindAmt)
        {
            SmallBlindAmount = smallBlindAmt;
            BigBlindAmount = smallBlindAmt * 2;
            LastBetAmount = BigBlindAmount;
        }
        public decimal LastBetAmount { get; private set; }
        public decimal TotalPotAmount { get; private set; }
        public decimal SmallBlindAmount { get; private set; }
        public decimal BigBlindAmount { get; private set; }

        #region Methods
        public void AddChipsToPot(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid bet amount.");
            TotalPotAmount += amount;
        }
        public void UpdateLastBetAmount(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid amount.");
            LastBetAmount = amount;
        }
        #endregion

    }
}
