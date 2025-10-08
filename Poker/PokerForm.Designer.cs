namespace BOLayer
{
    partial class PokerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokerForm));
            btnCall = new Button();
            btnRaise = new Button();
            ContainerPanel = new Panel();
            panelPlayerActions = new FlowLayoutPanel();
            btnFold = new Button();
            btnCheck = new Button();
            pbP2SbBb = new PictureBox();
            pbP1SbBb = new PictureBox();
            lblPlayerCombination = new Label();
            resultsPanel = new Panel();
            label1 = new Label();
            resultsP1Panel = new FlowLayoutPanel();
            lblResultsP2 = new Label();
            resultsP2Panel = new FlowLayoutPanel();
            lblResultsP1 = new Label();
            label4 = new Label();
            player1Panel = new FlowLayoutPanel();
            btnSound = new Button();
            lblInformation = new Label();
            player1AreaPanel = new Panel();
            lblPlayer1 = new Label();
            player2AreaPanel = new Panel();
            lblPlayer2 = new Label();
            player2Panel = new FlowLayoutPanel();
            panel5 = new Panel();
            lblBettingRound = new Label();
            boardPanel = new FlowLayoutPanel();
            panelStats = new Panel();
            lblSbBb = new Label();
            lblCurrentBet = new Label();
            lblPot = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            pBSpeech = new PictureBox();
            pbDealer = new PictureBox();
            PlayerTimer = new System.Windows.Forms.Timer(components);
            ContainerPanel.SuspendLayout();
            panelPlayerActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbP2SbBb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbP1SbBb).BeginInit();
            resultsPanel.SuspendLayout();
            player1AreaPanel.SuspendLayout();
            player2AreaPanel.SuspendLayout();
            panel5.SuspendLayout();
            panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBSpeech).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDealer).BeginInit();
            SuspendLayout();
            // 
            // btnCall
            // 
            btnCall.Anchor = AnchorStyles.Left;
            btnCall.AutoSize = true;
            btnCall.BackColor = Color.DimGray;
            btnCall.FlatAppearance.BorderColor = Color.White;
            btnCall.FlatStyle = FlatStyle.Flat;
            btnCall.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCall.ForeColor = Color.White;
            btnCall.Location = new Point(3, 195);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(146, 90);
            btnCall.TabIndex = 0;
            btnCall.Text = "CALL";
            btnCall.TextAlign = ContentAlignment.TopCenter;
            btnCall.UseVisualStyleBackColor = false;
            btnCall.Click += BtnCall_Click;
            // 
            // btnRaise
            // 
            btnRaise.Anchor = AnchorStyles.Left;
            btnRaise.AutoSize = true;
            btnRaise.BackColor = Color.Green;
            btnRaise.FlatAppearance.BorderColor = Color.White;
            btnRaise.FlatStyle = FlatStyle.Flat;
            btnRaise.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRaise.Location = new Point(3, 99);
            btnRaise.Name = "btnRaise";
            btnRaise.Size = new Size(146, 90);
            btnRaise.TabIndex = 2;
            btnRaise.Text = "RAISE";
            btnRaise.TextAlign = ContentAlignment.TopCenter;
            btnRaise.UseVisualStyleBackColor = false;
            btnRaise.Click += BtnRaise_Click;
            // 
            // ContainerPanel
            // 
            ContainerPanel.AutoSize = true;
            ContainerPanel.BackColor = Color.FromArgb(0, 64, 0);
            ContainerPanel.BackgroundImage = Poker.Properties.Resources.table;
            ContainerPanel.BackgroundImageLayout = ImageLayout.Center;
            ContainerPanel.Controls.Add(panelPlayerActions);
            ContainerPanel.Controls.Add(pbP2SbBb);
            ContainerPanel.Controls.Add(pbP1SbBb);
            ContainerPanel.Controls.Add(lblPlayerCombination);
            ContainerPanel.Controls.Add(resultsPanel);
            ContainerPanel.Controls.Add(label4);
            ContainerPanel.Controls.Add(player1Panel);
            ContainerPanel.Controls.Add(btnSound);
            ContainerPanel.Controls.Add(lblInformation);
            ContainerPanel.Controls.Add(player1AreaPanel);
            ContainerPanel.Controls.Add(player2AreaPanel);
            ContainerPanel.Controls.Add(panel5);
            ContainerPanel.Controls.Add(panelStats);
            ContainerPanel.Controls.Add(pBSpeech);
            ContainerPanel.Controls.Add(pbDealer);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(0, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1590, 916);
            ContainerPanel.TabIndex = 1;
            // 
            // panelPlayerActions
            // 
            panelPlayerActions.Anchor = AnchorStyles.Top;
            panelPlayerActions.BackColor = Color.Transparent;
            panelPlayerActions.Controls.Add(btnFold);
            panelPlayerActions.Controls.Add(btnRaise);
            panelPlayerActions.Controls.Add(btnCall);
            panelPlayerActions.Controls.Add(btnCheck);
            panelPlayerActions.FlowDirection = FlowDirection.TopDown;
            panelPlayerActions.Location = new Point(1000, 450);
            panelPlayerActions.Name = "panelPlayerActions";
            panelPlayerActions.Size = new Size(166, 437);
            panelPlayerActions.TabIndex = 32;
            // 
            // btnFold
            // 
            btnFold.Anchor = AnchorStyles.Left;
            btnFold.BackColor = Color.DarkRed;
            btnFold.BackgroundImageLayout = ImageLayout.None;
            btnFold.FlatAppearance.BorderColor = Color.White;
            btnFold.FlatStyle = FlatStyle.Flat;
            btnFold.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnFold.ForeColor = SystemColors.ButtonHighlight;
            btnFold.Location = new Point(3, 3);
            btnFold.Name = "btnFold";
            btnFold.Size = new Size(146, 90);
            btnFold.TabIndex = 14;
            btnFold.Text = "FOLD";
            btnFold.UseVisualStyleBackColor = false;
            btnFold.Click += BtnFold_Click;
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Left;
            btnCheck.BackColor = Color.RoyalBlue;
            btnCheck.FlatAppearance.BorderColor = Color.White;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCheck.Location = new Point(3, 291);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(146, 90);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "CHECK";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += BtnCheck_Click;
            // 
            // pbP2SbBb
            // 
            pbP2SbBb.BackColor = Color.Transparent;
            pbP2SbBb.BackgroundImageLayout = ImageLayout.None;
            pbP2SbBb.Location = new Point(595, 245);
            pbP2SbBb.Name = "pbP2SbBb";
            pbP2SbBb.Size = new Size(48, 48);
            pbP2SbBb.TabIndex = 31;
            pbP2SbBb.TabStop = false;
            // 
            // pbP1SbBb
            // 
            pbP1SbBb.BackColor = Color.Transparent;
            pbP1SbBb.BackgroundImageLayout = ImageLayout.None;
            pbP1SbBb.Location = new Point(595, 556);
            pbP1SbBb.Name = "pbP1SbBb";
            pbP1SbBb.Size = new Size(48, 48);
            pbP1SbBb.TabIndex = 30;
            pbP1SbBb.TabStop = false;
            // 
            // lblPlayerCombination
            // 
            lblPlayerCombination.BackColor = Color.Maroon;
            lblPlayerCombination.FlatStyle = FlatStyle.Flat;
            lblPlayerCombination.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerCombination.ForeColor = Color.Gold;
            lblPlayerCombination.Location = new Point(648, 584);
            lblPlayerCombination.Name = "lblPlayerCombination";
            lblPlayerCombination.Size = new Size(235, 37);
            lblPlayerCombination.TabIndex = 3;
            lblPlayerCombination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultsPanel
            // 
            resultsPanel.BackColor = Color.Maroon;
            resultsPanel.Controls.Add(label1);
            resultsPanel.Controls.Add(resultsP1Panel);
            resultsPanel.Controls.Add(lblResultsP2);
            resultsPanel.Controls.Add(resultsP2Panel);
            resultsPanel.Controls.Add(lblResultsP1);
            resultsPanel.Location = new Point(1050, 400);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(500, 384);
            resultsPanel.TabIndex = 29;
            resultsPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(158, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 4;
            label1.Text = "TOP 5 CARDS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultsP1Panel
            // 
            resultsP1Panel.BackColor = Color.Transparent;
            resultsP1Panel.Location = new Point(24, 104);
            resultsP1Panel.Name = "resultsP1Panel";
            resultsP1Panel.Size = new Size(450, 100);
            resultsP1Panel.TabIndex = 0;
            // 
            // lblResultsP2
            // 
            lblResultsP2.AutoSize = true;
            lblResultsP2.BackColor = Color.Black;
            lblResultsP2.FlatStyle = FlatStyle.Flat;
            lblResultsP2.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultsP2.ForeColor = Color.Gold;
            lblResultsP2.Location = new Point(2, 225);
            lblResultsP2.Name = "lblResultsP2";
            lblResultsP2.Size = new Size(48, 37);
            lblResultsP2.TabIndex = 3;
            lblResultsP2.Text = "P2";
            lblResultsP2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultsP2Panel
            // 
            resultsP2Panel.BackColor = Color.Transparent;
            resultsP2Panel.Location = new Point(24, 265);
            resultsP2Panel.Name = "resultsP2Panel";
            resultsP2Panel.Size = new Size(450, 100);
            resultsP2Panel.TabIndex = 1;
            // 
            // lblResultsP1
            // 
            lblResultsP1.AutoSize = true;
            lblResultsP1.BackColor = Color.Black;
            lblResultsP1.FlatStyle = FlatStyle.Flat;
            lblResultsP1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultsP1.ForeColor = Color.Gold;
            lblResultsP1.Location = new Point(0, 61);
            lblResultsP1.Name = "lblResultsP1";
            lblResultsP1.Size = new Size(44, 37);
            lblResultsP1.TabIndex = 2;
            lblResultsP1.Text = "P1";
            lblResultsP1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Candara", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(125, 458);
            label4.Name = "label4";
            label4.Size = new Size(180, 52);
            label4.TabIndex = 28;
            label4.Text = "DEALER";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1Panel
            // 
            player1Panel.Anchor = AnchorStyles.None;
            player1Panel.BackColor = Color.Transparent;
            player1Panel.Location = new Point(680, 624);
            player1Panel.Name = "player1Panel";
            player1Panel.Size = new Size(235, 100);
            player1Panel.TabIndex = 7;
            // 
            // btnSound
            // 
            btnSound.AutoSize = true;
            btnSound.BackColor = Color.FromArgb(0, 64, 0);
            btnSound.BackgroundImageLayout = ImageLayout.Center;
            btnSound.FlatAppearance.BorderColor = Color.White;
            btnSound.FlatAppearance.BorderSize = 0;
            btnSound.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSound.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSound.FlatStyle = FlatStyle.Flat;
            btnSound.Location = new Point(1513, 839);
            btnSound.Name = "btnSound";
            btnSound.Size = new Size(65, 65);
            btnSound.TabIndex = 25;
            btnSound.UseVisualStyleBackColor = false;
            btnSound.Click += BtnSound_Click;
            // 
            // lblInformation
            // 
            lblInformation.BackColor = Color.Transparent;
            lblInformation.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformation.ForeColor = SystemColors.ButtonHighlight;
            lblInformation.Location = new Point(23, 37);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(360, 82);
            lblInformation.TabIndex = 13;
            lblInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1AreaPanel
            // 
            player1AreaPanel.AutoSize = true;
            player1AreaPanel.BackColor = Color.Transparent;
            player1AreaPanel.Controls.Add(lblPlayer1);
            player1AreaPanel.Location = new Point(595, 624);
            player1AreaPanel.Name = "player1AreaPanel";
            player1AreaPanel.Size = new Size(403, 229);
            player1AreaPanel.TabIndex = 19;
            // 
            // lblPlayer1
            // 
            lblPlayer1.BackColor = Color.Black;
            lblPlayer1.FlatStyle = FlatStyle.Flat;
            lblPlayer1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer1.ForeColor = Color.Gold;
            lblPlayer1.Location = new Point(85, 108);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(161, 52);
            lblPlayer1.TabIndex = 2;
            lblPlayer1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player2AreaPanel
            // 
            player2AreaPanel.BackColor = Color.Transparent;
            player2AreaPanel.Controls.Add(lblPlayer2);
            player2AreaPanel.Controls.Add(player2Panel);
            player2AreaPanel.Location = new Point(595, 28);
            player2AreaPanel.Name = "player2AreaPanel";
            player2AreaPanel.Size = new Size(403, 220);
            player2AreaPanel.TabIndex = 18;
            // 
            // lblPlayer2
            // 
            lblPlayer2.BackColor = Color.Black;
            lblPlayer2.FlatStyle = FlatStyle.Flat;
            lblPlayer2.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer2.ForeColor = Color.Gold;
            lblPlayer2.Location = new Point(85, 152);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(161, 52);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player2Panel
            // 
            player2Panel.Anchor = AnchorStyles.Top;
            player2Panel.BackColor = Color.Transparent;
            player2Panel.Location = new Point(85, 49);
            player2Panel.Name = "player2Panel";
            player2Panel.Size = new Size(235, 100);
            player2Panel.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(lblBettingRound);
            panel5.Controls.Add(boardPanel);
            panel5.Location = new Point(458, 309);
            panel5.Name = "panel5";
            panel5.Size = new Size(674, 259);
            panel5.TabIndex = 17;
            // 
            // lblBettingRound
            // 
            lblBettingRound.BackColor = Color.Transparent;
            lblBettingRound.Font = new Font("Algerian", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBettingRound.ForeColor = Color.White;
            lblBettingRound.Location = new Point(-2, -26);
            lblBettingRound.Name = "lblBettingRound";
            lblBettingRound.Size = new Size(678, 130);
            lblBettingRound.TabIndex = 1;
            lblBettingRound.Text = "Betting Round";
            lblBettingRound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boardPanel
            // 
            boardPanel.Location = new Point(115, 107);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(445, 139);
            boardPanel.TabIndex = 13;
            // 
            // panelStats
            // 
            panelStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelStats.Controls.Add(lblSbBb);
            panelStats.Controls.Add(lblCurrentBet);
            panelStats.Controls.Add(lblPot);
            panelStats.Controls.Add(label6);
            panelStats.Controls.Add(label7);
            panelStats.Controls.Add(label5);
            panelStats.Controls.Add(label8);
            panelStats.Location = new Point(1110, 12);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(471, 291);
            panelStats.TabIndex = 16;
            // 
            // lblSbBb
            // 
            lblSbBb.BackColor = Color.White;
            lblSbBb.Font = new Font("Segoe UI", 16.2F);
            lblSbBb.Location = new Point(345, 80);
            lblSbBb.Name = "lblSbBb";
            lblSbBb.Size = new Size(104, 54);
            lblSbBb.TabIndex = 6;
            lblSbBb.Text = "label8";
            lblSbBb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentBet
            // 
            lblCurrentBet.BackColor = Color.White;
            lblCurrentBet.Font = new Font("Segoe UI", 16.2F);
            lblCurrentBet.Location = new Point(345, 210);
            lblCurrentBet.Name = "lblCurrentBet";
            lblCurrentBet.Size = new Size(104, 52);
            lblCurrentBet.TabIndex = 5;
            lblCurrentBet.Text = "N21";
            lblCurrentBet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPot
            // 
            lblPot.BackColor = Color.White;
            lblPot.Font = new Font("Segoe UI", 16.2F);
            lblPot.Location = new Point(345, 144);
            lblPot.Name = "lblPot";
            lblPot.Size = new Size(104, 52);
            lblPot.TabIndex = 4;
            lblPot.Text = "label8";
            lblPot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 19.8000011F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 89);
            label6.Name = "label6";
            label6.Size = new Size(291, 41);
            label6.TabIndex = 2;
            label6.Text = "SMALL / BIG BLIND";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 19.8000011F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 221);
            label7.Name = "label7";
            label7.Size = new Size(231, 41);
            label7.TabIndex = 3;
            label7.Text = "MINIMUM BET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 19.8000011F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 151);
            label5.Name = "label5";
            label5.Size = new Size(79, 41);
            label5.TabIndex = 1;
            label5.Text = "POT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(38, 16);
            label8.Name = "label8";
            label8.Size = new Size(411, 40);
            label8.TabIndex = 0;
            label8.Text = "Texas Hold'em Poker";
            // 
            // pBSpeech
            // 
            pBSpeech.BackColor = Color.Transparent;
            pBSpeech.BackgroundImageLayout = ImageLayout.Center;
            pBSpeech.Image = Poker.Properties.Resources.speech1;
            pBSpeech.Location = new Point(162, 92);
            pBSpeech.Name = "pBSpeech";
            pBSpeech.Size = new Size(390, 226);
            pBSpeech.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSpeech.TabIndex = 24;
            pBSpeech.TabStop = false;
            // 
            // pbDealer
            // 
            pbDealer.BackColor = Color.Transparent;
            pbDealer.BackgroundImageLayout = ImageLayout.Center;
            pbDealer.Location = new Point(125, 298);
            pbDealer.Name = "pbDealer";
            pbDealer.Size = new Size(180, 180);
            pbDealer.TabIndex = 23;
            pbDealer.TabStop = false;
            // 
            // PlayerTimer
            // 
            PlayerTimer.Interval = 1200;
            PlayerTimer.Tick += PlayerTimer_Tick;
            // 
            // PokerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 916);
            Controls.Add(ContainerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1412, 867);
            Name = "PokerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Poker";
            Load += Form1_Load;
            ContainerPanel.ResumeLayout(false);
            ContainerPanel.PerformLayout();
            panelPlayerActions.ResumeLayout(false);
            panelPlayerActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbP2SbBb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbP1SbBb).EndInit();
            resultsPanel.ResumeLayout(false);
            resultsPanel.PerformLayout();
            player1AreaPanel.ResumeLayout(false);
            player2AreaPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBSpeech).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDealer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCall;
        private Button btnRaise;
        private Panel ContainerPanel;
        private FlowLayoutPanel player2Panel;
        private Label lblBettingRound;
        private System.Windows.Forms.Timer PlayerTimer;
        private Label lblInformation;
        private Button btnFold;
        private Button btnCheck;
        private Panel panelStats;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label lblSbBb;
        private Label lblCurrentBet;
        private Label lblPot;
        private FlowLayoutPanel boardPanel;
        private Panel panel5;
        private Panel player2AreaPanel;
        private Panel player1AreaPanel;
        private FlowLayoutPanel player1Panel;
        private PictureBox pbDealer;
        private PictureBox pBSpeech;
        private Button btnSound;
        private Label label4;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Panel resultsPanel;
        private FlowLayoutPanel resultsP2Panel;
        private FlowLayoutPanel resultsP1Panel;
        private Label lblResultsP2;
        private Label lblResultsP1;
        private Label label1;
        private Label lblPlayerCombination;
        private PictureBox pbP1SbBb;
        private PictureBox pbP2SbBb;
        private FlowLayoutPanel panelPlayerActions;
    }
}
