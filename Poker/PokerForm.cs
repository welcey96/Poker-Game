using Poker;
using System.Media;

namespace BOLayer
{
    public partial class PokerForm : Form
    {
        private const int TOTAL_PLAYERS = 2;
        private bool isMuteSound = false;
        private List<FlowLayoutPanel> playerPanels = new();
        private Game game = new();
        private SoundPlayer sound = new();
        private Task? task;
        public PokerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StartGame();
            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }

        }

        private void StartGame(bool isNewGame = false)
        {
            if (isNewGame)
            {
                game = new();
                playerPanels = new();
                UIClearPlayersHand(true);
            }

            game.AddPlayers(TOTAL_PLAYERS);
            game.SetCurrentPlayerIndex(0, true);
            UIPrepareAreaAndControls();

            UIUpdateDealerSpeechBubble("Pre-flop round, place your bets...");
            game.DealHoleCards();

            UIShowCards();
            UITogglePlayerActionButtons();
            UIShowBettingStage();
            UIShowUpdatedInfo();

            PlayerTimer.Start();
        }
        private void PlayTheWinningSound()
        {
            sound = new($@"assets\texas_hold_em.wav");
            sound.Play();
        }
        private void DelayTask(int interval = 500)
        {
            task = Task.Delay(interval);
            task.Wait();

        }
        private void ProcessActions(PlayerAction action)
        {
            switch (action)
            {
                case PlayerAction.FOLD:
                    UITogglePlayerActionButtons();
                    game.FoldPlayer();
                    UIShowUpdatedInfo();
                    UIUpdateDealerSpeechBubble($"{game[game.PlayerIndex].Name} Folded!", true);


                    if (game.IsPreFlop() && (
                        game[game.PlayerIndex].IsSmallBlind ||
                        game[game.PlayerIndex].IsBigBlind))
                    {
                        Player p = game[game.PlayerIndex];
                        string msg = $"{(p.IsBigBlind ? "Big blind" : p.IsSmallBlind ?
                            "Small blind" : "")} adds force bet amount of " +
                            $"{(p.IsBigBlind ? game.Pot.BigBlindAmount : p.IsSmallBlind ?
                            game.Pot.BigBlindAmount : 0):c0} to pot";
                        UIUpdateDealerSpeechBubble(msg, true, 1500);
                    }


                    game.MoveToNextPlayer();
                    game.AddPotAmountToWinner(game[game.PlayerIndex]);
                    UIShowUpdatedInfo();
                    UIUpdateDealerSpeechBubble($"{game[game.PlayerIndex].Name} WINS!");

                    ShowPlayAgainPrompt();
                    break;

                case PlayerAction.CHECK:
                    game.ProcessCheck();
                    UIUpdateDealerSpeechBubble($"{game[game.PlayerIndex].Name} checked!");
                    UpdateControlsAfterBetAction();
                    break;

                case PlayerAction.CALL:
                case PlayerAction.RAISE:

                    if (action == PlayerAction.CALL)
                        game.ProcessCallBet();
                    else
                        game.ProcessRaiseBet();

                    string text =
                      $"{game[game.PlayerIndex].Name} " +
                      $"{(action == PlayerAction.CALL ? "matched the bet of" : "raised bet to")} " +
                      $"{game.Pot.LastBetAmount:c0}";

                    UIUpdateDealerSpeechBubble(text);
                    UpdateControlsAfterBetAction();

                    break;
            }
        }
        private void UpdateControlsAfterBetAction()
        {
            UIShowUpdatedInfo();

            if (game.PlayerIndex == 0)
            {
                UITogglePlayerActionButtons();
                game.MoveToNextRound();
                DelayTask(800);

                int stage = game.BettingRound;

                if (stage <= (int)Stage.River)
                {
                    UIUpdateDealerSpeechBubble($"Moving to {(Stage)stage} {(stage <= (int)Stage.River ? "round" : "")}", true);
                    UIShowBettingStage();
                    UIUpdateDealerSpeechBubble($"Dealing {(stage == (int)Stage.Flop ? 3 : 1)} card{(stage == (int)Stage.Flop ? 's' : "")}...", true);
                    UIShowCommunityCards();
                }
                else
                    UIShowBettingStage();
            }

            game.MoveToNextPlayer();
            PlayerTimer.Start();
        }

        private void ShowPlayAgainPrompt()
        {
            using (GamePrompt prompt = new())
            {
                DelayTask(3000);
                DialogResult result = prompt.ShowDialog();
                if (result == DialogResult.Cancel)
                    StartGame(true);
            }
        }

        #region UI specific methods
        private void UIShowBettingStage()
        {
            lblBettingRound.Text = Utilities.TransformBettingStage(game.BettingRound);
        }
        private void UIPrepareAreaAndControls()
        {
            pbP1SbBb.BackgroundImage = Image.FromFile($@"assets\{(game[0].IsSmallBlind ? "sb.png" : "bb.png")}");
            pbP2SbBb.BackgroundImage = Image.FromFile($@"assets\{(game[1].IsSmallBlind ? "sb.png" : "bb.png")}");
            pbDealer.BackgroundImage = Image.FromFile($@"assets\doge.png");
            if (!isMuteSound) btnSound.BackgroundImage = Image.FromFile($@"assets\sound.png");
            lblInformation.Parent = pBSpeech;
            playerPanels.AddRange([player1Panel, player2Panel]);
            resultsPanel.Hide();
            lblPlayerCombination.Hide();
            sound.Stop();
        }
        private static void UIShowCard(Panel panel, Card card, bool isFaceUp = true)
        {
            string imgPath = $@"assets\{(isFaceUp ? $"{card.FaceValue}{card.Suit}.jpg"
                : "cardback.gif")}";

            PictureBox pic = new()
            {
                Image = Image.FromFile(imgPath),
                Text = $"{card.FaceValue}{card.Suit}",
                Width = 80,
                Height = 100,
                Tag = card
            };

            panel.Controls.Add(pic);
        }
        private void UIShowCards(bool isRevealAll = false)
        {
            UIClearPlayersHand();
            List<Player> players = game.GetPlayers();
            for (int i = 0; i < players.Count; i++)
            {
                for (int j = 0; j < players[i].Hand.Count; j++)
                {
                    UIShowCard(playerPanels[i], players[i].Hand[j], !isRevealAll ? i == 0 : isRevealAll);
                }

                string text = $"{players[i].Name} / {players[i].Chips:c0}";

                if (i == 0)
                    lblPlayer1.Text = text;
                else
                    lblPlayer2.Text = text;
            }
        }
        private void UIShowCommunityCards()
        {
            Hand communityCards = game.DealCommunityCards();
            for (int j = 0; j < communityCards.Count; j++)
            {
                UIShowCard(boardPanel, communityCards[j], true);
            }

        }
        private void UIClearPlayersHand(bool isClearAll = false)
        {
            List<FlowLayoutPanel> panels = new() { player1Panel, player2Panel };

            if (isClearAll)
                panels.AddRange([boardPanel, resultsP1Panel, resultsP2Panel]);

            foreach (FlowLayoutPanel p in panels)
            {
                foreach (var pb in p.Controls.OfType<PictureBox>().ToList())
                {
                    p.Controls.Remove(pb);
                }
            }
        }
        private void UIUpdateDealerSpeechBubble(string? message = null, bool isDelay = false, int delayMS = 500)
        {
            Player player = game[game.PlayerIndex];
            string msg = $"{(player.Type == PlayerType.Bot ?
                $"{player.Name}'s" : "Your")} turn to bet";

            lblInformation.Text = message ?? msg;

            if (isDelay)
                DelayTask(delayMS);
        }
        private void UITogglePlayerActionButtons(bool isHide = true)
        {
            btnCall.Text = $"CALL\n{game.GetCallAmount():c0}";
            btnRaise.Text = $"RAISE\n{game.GetRaiseAmount():c0}";

            if (isHide)
            {
                panelPlayerActions.Hide();
                return;
            }

            if (game.IsPreFlop() || !game.IsCheckAllowed)
                btnCheck.Hide();
            else
                btnCheck.Show();

            if (game[game.PlayerIndex].Chips < game.Pot.LastBetAmount)
                btnCall.Hide();
            else
                btnCall.Show();

            if (game[game.PlayerIndex].Chips < game.Pot.LastBetAmount * 2)
                btnRaise.Hide();
            else
                btnRaise.Show();

            panelPlayerActions.Show();
        }
        private void UIHandleCaughtError(string err)
        {
            MessageBox.Show(err, "Error");
            PlayerTimer.Stop();
        }
        private void UIShowUpdatedInfo(bool updateAllPlayers = false)
        {
            if (game.IsPreFlop())
                lblSbBb.Text = $"{game.Pot.SmallBlindAmount:c0} / {game.Pot.BigBlindAmount:c0}";

            string text = $"{game[game.PlayerIndex].Name} / {game[game.PlayerIndex].Chips:c0}";

            if (!updateAllPlayers)
            {
                if (game.PlayerIndex == 0)
                    lblPlayer1.Text = text;
                else
                    lblPlayer2.Text = text;
            }
            else
            {
                game.GetPlayers().ForEach(p =>
                {
                    text = $"{p.Name} / {p.Chips:c0}";

                    if (p.Type == PlayerType.Human)
                        lblPlayer1.Text = text;
                    else if (p.Type == PlayerType.Bot)
                        lblPlayer2.Text = text;
                });
            }

            lblPot.Text = $"{game.Pot.TotalPotAmount:c0}";
            lblCurrentBet.Text = $"{game.Pot.LastBetAmount:c0}";
        }

        private void UIDisplayPlayerHighestCombination(Combination combination)
        {
            lblPlayerCombination.Text = Utilities.TransfomCombination(combination);
            lblPlayerCombination.Show();
        }
        private void UIShowTopCardsPerPlayer()
        {
            game.GetPlayers().ForEach(p =>
            {
                FlowLayoutPanel panel;
                string text = $"{p.Name} | {Utilities.TransfomCombination(p.CardCombination)}";

                if (p.Type == PlayerType.Human)
                {
                    panel = resultsP1Panel;
                    lblResultsP1.Text = text;
                }
                else
                {
                    panel = resultsP2Panel;
                    lblResultsP2.Text = text;
                }

                game.GetTopCards(p).GetCards().ForEach(card =>
                {
                    UIShowCard(panel, card);
                });

                resultsPanel.Controls.Add(panel);
            });

            resultsPanel.Show();

        }

        #endregion

        #region Events
        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                PlayerTimer.Stop();

                if (game.BettingRound <= (int)Stage.River)
                {
                    if (!game[game.PlayerIndex].IsFolded)
                    {
                        Combination combination = game.CalculateHighestCardCombination();
                        game.SetPlayerHandCombination(combination);

                        if (game.PlayerIndex == 0)
                        {
                            UIUpdateDealerSpeechBubble();
                            UITogglePlayerActionButtons(false);
                            UIDisplayPlayerHighestCombination(combination);
                        }
                        else
                        {
                            UIUpdateDealerSpeechBubble();
                            ProcessActions(game.GetOpponentBetAction());
                        }
                    }
                    else
                    {
                        ProcessActions(PlayerAction.FOLD);
                    }
                }
                else
                {
                    UIUpdateDealerSpeechBubble("Showing all cards", true);
                    UIShowCards(true);
                    UIUpdateDealerSpeechBubble("Determining winner...", true, 800);

                    Player? winner = game.DetermineWinner();
                    if (winner != null)
                        UIUpdateDealerSpeechBubble($"{winner.Name} WIN{(winner.Type == PlayerType.Bot ? "S" : "")}!!!", true);
                    else
                        UIUpdateDealerSpeechBubble($"SPLIT POT! Both Player WINS!", true);

                    if (!isMuteSound)
                        PlayTheWinningSound();

                    UIShowTopCardsPerPlayer();
                    game.AddPotAmountToWinner(winner);

                    UIShowUpdatedInfo(true);
                    ShowPlayAgainPrompt();

                }
            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }
        }
        private void BtnFold_Click(object sender, EventArgs e)
        {
            try
            {

                ProcessActions(PlayerAction.FOLD);

            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }
        }
        private void BtnCall_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessActions(PlayerAction.CALL);

            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }
        }
        private void BtnRaise_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessActions(PlayerAction.RAISE);
            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }

        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessActions(PlayerAction.CHECK);
            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }
        }
        private void BtnSound_Click(object sender, EventArgs e)
        {
            try
            {
                isMuteSound = !isMuteSound;
                if (isMuteSound)
                {
                    btnSound.BackgroundImage = Image.FromFile($@"assets\nosound.png");
                    sound.Stop();
                    return;
                }
                sound.Play();
                btnSound.BackgroundImage = Image.FromFile($@"assets\sound.png");
            }
            catch (Exception ex)
            {
                UIHandleCaughtError(ex.Message);
            }
        }

        #endregion

    }
}
