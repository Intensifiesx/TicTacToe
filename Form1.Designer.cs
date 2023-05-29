
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.playerTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerXWins = new System.Windows.Forms.Label();
            this.playerYWins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ties = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.Location = new System.Drawing.Point(330, 38);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(74, 13);
            this.playerTurn.TabIndex = 0;
            this.playerTurn.Text = "Player X\'s turn";
            this.playerTurn.Click += new System.EventHandler(this.playerTurn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player X Wins";
            // 
            // PlayerXWins
            // 
            this.PlayerXWins.AutoSize = true;
            this.PlayerXWins.Location = new System.Drawing.Point(470, 93);
            this.PlayerXWins.Name = "PlayerXWins";
            this.PlayerXWins.Size = new System.Drawing.Size(13, 13);
            this.PlayerXWins.TabIndex = 2;
            this.PlayerXWins.Text = "0";
            // 
            // playerYWins
            // 
            this.playerYWins.AutoSize = true;
            this.playerYWins.Location = new System.Drawing.Point(470, 134);
            this.playerYWins.Name = "playerYWins";
            this.playerYWins.Size = new System.Drawing.Size(13, 13);
            this.playerYWins.TabIndex = 4;
            this.playerYWins.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Player O Wins";
            // 
            // ties
            // 
            this.ties.AutoSize = true;
            this.ties.Location = new System.Drawing.Point(470, 168);
            this.ties.Name = "ties";
            this.ties.Size = new System.Drawing.Size(13, 13);
            this.ties.TabIndex = 6;
            this.ties.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ties";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(68, 38);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(74, 78);
            this.box1.TabIndex = 7;
            this.box1.UseVisualStyleBackColor = true;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(148, 38);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(74, 78);
            this.box2.TabIndex = 8;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(228, 38);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(74, 78);
            this.box3.TabIndex = 9;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(68, 122);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(74, 78);
            this.box4.TabIndex = 10;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(148, 122);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(74, 78);
            this.box5.TabIndex = 11;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box6
            // 
            this.box6.Location = new System.Drawing.Point(228, 122);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(74, 78);
            this.box6.TabIndex = 12;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box7
            // 
            this.box7.Location = new System.Drawing.Point(68, 206);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(74, 78);
            this.box7.TabIndex = 13;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // box8
            // 
            this.box8.Location = new System.Drawing.Point(148, 206);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(74, 78);
            this.box8.TabIndex = 14;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box9
            // 
            this.box9.Location = new System.Drawing.Point(228, 206);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(74, 78);
            this.box9.TabIndex = 15;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(83, 387);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(335, 54);
            this.quit.TabIndex = 17;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.button11_Click);
            // 
            // playAgain
            // 
            this.playAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playAgain.Location = new System.Drawing.Point(83, 306);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(335, 54);
            this.playAgain.TabIndex = 18;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 496);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.ties);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerYWins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerXWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerTurn);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerXWins;
        private System.Windows.Forms.Label playerYWins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ties;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button playAgain;
    }
}

