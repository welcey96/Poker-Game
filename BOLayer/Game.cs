using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Game
    {
        private Deck deck = new();
        private List<Player> players = new();
        private Hand communityCards = new();
        private Dictionary<Player, Hand> playersTopCards = new();
        private Random random = new();
        public Pot Pot { get; private set; } = new(1);
        public int PlayerIndex { get; private set; }
        public int BettingRound { get; private set; } = (int)Stage.PreFlop;
        public Player this[int index] { get => players[index]; set => players[index] = value; }
        public bool IsCheckAllowed { get; private set; } = false;

        #region Methods
        public List<Player> GetPlayers() { return players; }
        public bool IsPreFlop() { return BettingRound == (int)Stage.PreFlop; }
        public void AddPlayers(int totalPlayers)
        {
            for (int i = 0; i < totalPlayers; i++)
            {
                Player player = new()
                {
                    Name = i == 0 ? "YOU" : $"BOT",
                    IsSmallBlind = i == 1,
                    IsBigBlind = i == 2,
                    Type = i == 0 ? PlayerType.Human : PlayerType.Bot,
                };

                if (totalPlayers == 2)
                    player.IsBigBlind = i == 0;

                players.Add(player);
            }
        }
        public void DealHoleCards()
        {
            deck.Shuffle();
            players.ForEach(p => p.Hand = deck.DealHand(2));
        }
        public Hand DealCommunityCards()
        {
            Hand cards = new();
            switch (BettingRound)
            {
                case (int)Stage.Flop:
                    cards = deck.DealHand(3);
                    break;
                case (int)Stage.Turn:
                case (int)Stage.River:
                    cards = deck.DealHand(1);
                    break;
            }

            communityCards.AddCard(cards.GetCards());

            return cards;
        }
        public void SetCurrentPlayerIndex(int num = 0, bool isUTG = false)
        {
            if (num < 0)
                throw new ArgumentException("Invalid index position.");

            if (isUTG)
                num = players.FindLastIndex(p => p.IsBigBlind) + 1;

            PlayerIndex = num >= players.Count ? 0 : num;
        }
        public void MoveToNextPlayer()
        {
            SetCurrentPlayerIndex(++PlayerIndex);
        }
        public void MoveToNextRound()
        {
            BettingRound += 1;
            IsCheckAllowed = false;
        }
        public decimal GetCallAmount()
        {
            return Pot.LastBetAmount;
        }
        public decimal GetRaiseAmount() { return Pot.LastBetAmount * 2; }
        public void FoldPlayer()
        {
            players[PlayerIndex].IsFolded = true;

            if (IsPreFlop() && (players[PlayerIndex].IsSmallBlind || players[PlayerIndex].IsBigBlind))
            {
                decimal chips = players[PlayerIndex].IsSmallBlind ?
                    Pot.SmallBlindAmount : Pot.BigBlindAmount;
                players[PlayerIndex].DeductChips(chips);
                Pot.AddChipsToPot(chips);
            }
        }
        public void SetPlayerHandCombination(Combination combination)
        {
            players[PlayerIndex].CardCombination = combination;
        }
        public void ProcessCallBet()
        {
            players[PlayerIndex].DeductChips(Pot.LastBetAmount);
            Pot.AddChipsToPot(Pot.LastBetAmount);
        }
        public void ProcessRaiseBet()
        {
            Pot.UpdateLastBetAmount(Pot.LastBetAmount * 2);
            players[PlayerIndex].DeductChips(Pot.LastBetAmount);
            Pot.AddChipsToPot(Pot.LastBetAmount);
        }
        public void ProcessCheck()
        {
            IsCheckAllowed = true;
        }
        public Combination CalculateHighestCardCombination()
        {
            return PokerEvaluator.EvaluateTopCombination(MergeHand(players[PlayerIndex], communityCards));
        }
        public Player? DetermineWinner()
        {
            players.ForEach(p =>
            {
                playersTopCards.Add(p, PokerEvaluator.GetTopCards(p.CardCombination, MergeHand(p, communityCards)));
            });

            if (playersTopCards.Count != 2)
                throw new Exception("Cannot determine winner.");

            if (playersTopCards.Keys.FirstOrDefault()!.CardCombination !=
                playersTopCards.Keys.LastOrDefault()!.CardCombination)

                return playersTopCards
                    .OrderByDescending(k => k.Key.CardCombination)
                    .FirstOrDefault().Key;


            for (int i = 0; i < PokerEvaluator.TOP_CARD_COUNT; i++)
            {
                if (playersTopCards.FirstOrDefault().Value[i].FaceValue ==
                    playersTopCards.LastOrDefault().Value[i].FaceValue)
                    continue;

                return playersTopCards.FirstOrDefault().Value[i].FaceValue >
                    playersTopCards.LastOrDefault().Value[i].FaceValue ?
                    playersTopCards.FirstOrDefault().Key :
                    playersTopCards.LastOrDefault().Key;
            }

            return null;
        }
        public Hand GetTopCards(Player p)
        {
            playersTopCards.TryGetValue(p, out Hand? cards);

            if (cards == null)
                throw new Exception("Cannot determine winner.");
            return cards;
        }
        public void AddPotAmountToWinner(Player? winner)
        {
            decimal chips = Pot.TotalPotAmount;
            if (winner == null)
            {
                chips /= 2;
                players.ForEach(p =>
                {
                    p.AddChips(chips);
                });

                return;
            }
            Player? player = players.FirstOrDefault(p => p.Name == winner.Name) ??
                throw new Exception("Single winner cannot be found.");

            player.AddChips(chips);
        }
        public PlayerAction GetOpponentBetAction()
        {
            List<PlayerAction> options = [PlayerAction.CALL];

            if (!IsPreFlop())
            {
                options.Add(PlayerAction.CHECK);

                if (BettingRound < (int)Stage.River)
                    options.Add(PlayerAction.RAISE);
            }

            int choice = random.Next(options.Count);

            return options[choice];
        }
        private Hand MergeHand(Player player, Hand communityCards)
        {
            Hand hand = new();
            hand.AddCard(player.Hand.GetCards());
            hand.AddCard(communityCards.GetCards());
            return hand;
        }
        #endregion

    }
}
