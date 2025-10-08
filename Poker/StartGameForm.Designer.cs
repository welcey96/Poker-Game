namespace Poker
{
    partial class StartGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGameForm));
            btnPlay = new Button();
            btnQuit = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Maroon;
            btnPlay.FlatAppearance.BorderColor = Color.Goldenrod;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
            btnPlay.ForeColor = SystemColors.Control;
            btnPlay.Location = new Point(46, 160);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(292, 61);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += playBtn_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Maroon;
            btnQuit.FlatAppearance.BorderColor = Color.Goldenrod;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
            btnQuit.ForeColor = SystemColors.Control;
            btnQuit.Location = new Point(46, 240);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(292, 61);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 95);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(12, 83);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(372, 37);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Texas Hold'em Poker";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 95);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // StartGameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(388, 402);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(btnQuit);
            Controls.Add(btnPlay);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NumOpponentsPopup";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlay;
        private Button btnQuit;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private PictureBox pictureBox2;
    }
}