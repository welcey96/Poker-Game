namespace Poker
{
    partial class GamePrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewGame = new Button();
            btnQuit = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.Maroon;
            btnNewGame.FlatAppearance.BorderColor = Color.Goldenrod;
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
            btnNewGame.ForeColor = SystemColors.Control;
            btnNewGame.Location = new Point(45, 141);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(292, 61);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "NEW GAME";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Maroon;
            btnQuit.FlatAppearance.BorderColor = Color.Goldenrod;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
            btnQuit.ForeColor = SystemColors.Control;
            btnQuit.Location = new Point(45, 225);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(292, 61);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(85, 67);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 37);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Play Again?";
            // 
            // GamePrompt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(388, 402);
            ControlBox = false;
            Controls.Add(lblTitle);
            Controls.Add(btnQuit);
            Controls.Add(btnNewGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "GamePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Play Again?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Button btnQuit;
        private Label lblTitle;
    }
}