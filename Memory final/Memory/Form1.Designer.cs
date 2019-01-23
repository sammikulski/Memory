namespace Memory
{
    partial class frmMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemory));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblFirstPlayerInstr = new System.Windows.Forms.Label();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.txtFirstPlayerName = new System.Windows.Forms.TextBox();
            this.btnFirstPlayerOK = new System.Windows.Forms.Button();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.txtSecondPlayerName = new System.Windows.Forms.TextBox();
            this.btnSecondPlayerOK = new System.Windows.Forms.Button();
            this.lblInstrTransition = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblNumPoints = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(223, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(314, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Matching Game!";
            // 
            // lblFirstPlayerInstr
            // 
            this.lblFirstPlayerInstr.AutoSize = true;
            this.lblFirstPlayerInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerInstr.Location = new System.Drawing.Point(108, 34);
            this.lblFirstPlayerInstr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstPlayerInstr.Name = "lblFirstPlayerInstr";
            this.lblFirstPlayerInstr.Size = new System.Drawing.Size(564, 20);
            this.lblFirstPlayerInstr.TabIndex = 1;
            this.lblFirstPlayerInstr.Text = "Please enter both player\'s names below. Player 1 will start as the current player" +
    ".";
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.Location = new System.Drawing.Point(217, 83);
            this.lblFirstPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(114, 16);
            this.lblFirstPlayerName.TabIndex = 2;
            this.lblFirstPlayerName.Text = "First player name:";
            // 
            // txtFirstPlayerName
            // 
            this.txtFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPlayerName.Location = new System.Drawing.Point(340, 79);
            this.txtFirstPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstPlayerName.Name = "txtFirstPlayerName";
            this.txtFirstPlayerName.Size = new System.Drawing.Size(88, 22);
            this.txtFirstPlayerName.TabIndex = 3;
            // 
            // btnFirstPlayerOK
            // 
            this.btnFirstPlayerOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPlayerOK.Location = new System.Drawing.Point(432, 79);
            this.btnFirstPlayerOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPlayerOK.Name = "btnFirstPlayerOK";
            this.btnFirstPlayerOK.Size = new System.Drawing.Size(50, 24);
            this.btnFirstPlayerOK.TabIndex = 4;
            this.btnFirstPlayerOK.Text = "OK";
            this.btnFirstPlayerOK.UseVisualStyleBackColor = true;
            this.btnFirstPlayerOK.Click += new System.EventHandler(this.btnFirstPlayerOK_Click);
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.Location = new System.Drawing.Point(195, 118);
            this.lblSecondPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(136, 16);
            this.lblSecondPlayerName.TabIndex = 6;
            this.lblSecondPlayerName.Text = "Second player name:";
            this.lblSecondPlayerName.Visible = false;
            // 
            // txtSecondPlayerName
            // 
            this.txtSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPlayerName.Location = new System.Drawing.Point(340, 116);
            this.txtSecondPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondPlayerName.Name = "txtSecondPlayerName";
            this.txtSecondPlayerName.Size = new System.Drawing.Size(88, 22);
            this.txtSecondPlayerName.TabIndex = 7;
            this.txtSecondPlayerName.Visible = false;
            // 
            // btnSecondPlayerOK
            // 
            this.btnSecondPlayerOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPlayerOK.Location = new System.Drawing.Point(432, 116);
            this.btnSecondPlayerOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecondPlayerOK.Name = "btnSecondPlayerOK";
            this.btnSecondPlayerOK.Size = new System.Drawing.Size(50, 24);
            this.btnSecondPlayerOK.TabIndex = 8;
            this.btnSecondPlayerOK.Text = "OK";
            this.btnSecondPlayerOK.UseVisualStyleBackColor = true;
            this.btnSecondPlayerOK.Visible = false;
            this.btnSecondPlayerOK.Click += new System.EventHandler(this.btnSecondPlayerOK_Click);
            // 
            // lblInstrTransition
            // 
            this.lblInstrTransition.AutoSize = true;
            this.lblInstrTransition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrTransition.Location = new System.Drawing.Point(72, 183);
            this.lblInstrTransition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrTransition.Name = "lblInstrTransition";
            this.lblInstrTransition.Size = new System.Drawing.Size(654, 20);
            this.lblInstrTransition.TabIndex = 9;
            this.lblInstrTransition.Text = "Let the game begin! Now follow the directions below and whoever gets the most poi" +
    "nts wins!";
            this.lblInstrTransition.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(35, 210);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(691, 80);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstructions.Visible = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(125, 304);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(511, 439);
            this.pnlBoard.TabIndex = 11;
            this.pnlBoard.Visible = false;
            // 
            // lblNumPoints
            // 
            this.lblNumPoints.AutoSize = true;
            this.lblNumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPoints.Location = new System.Drawing.Point(479, 58);
            this.lblNumPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPoints.Name = "lblNumPoints";
            this.lblNumPoints.Size = new System.Drawing.Size(64, 20);
            this.lblNumPoints.TabIndex = 13;
            this.lblNumPoints.Text = "Points:";
            this.lblNumPoints.Visible = false;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(203, 153);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(128, 20);
            this.lblCurrentPlayer.TabIndex = 16;
            this.lblCurrentPlayer.Text = "Current Player:";
            this.lblCurrentPlayer.Visible = false;
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPlayer.Location = new System.Drawing.Point(340, 149);
            this.txtCurrentPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(88, 26);
            this.txtCurrentPlayer.TabIndex = 17;
            this.txtCurrentPlayer.Visible = false;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(493, 112);
            this.lblPlayer2Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(21, 24);
            this.lblPlayer2Score.TabIndex = 14;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.Visible = false;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(493, 79);
            this.lblPlayer1Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(21, 24);
            this.lblPlayer1Score.TabIndex = 15;
            this.lblPlayer1Score.Text = "0";
            this.lblPlayer1Score.Visible = false;
            // 
            // btnAgain
            // 
            this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.ForeColor = System.Drawing.Color.Teal;
            this.btnAgain.Location = new System.Drawing.Point(652, 318);
            this.btnAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(98, 30);
            this.btnAgain.TabIndex = 19;
            this.btnAgain.Text = "Play Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(652, 362);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 27);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(761, 757);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblNumPoints);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblInstrTransition);
            this.Controls.Add(this.btnSecondPlayerOK);
            this.Controls.Add(this.txtSecondPlayerName);
            this.Controls.Add(this.lblSecondPlayerName);
            this.Controls.Add(this.btnFirstPlayerOK);
            this.Controls.Add(this.txtFirstPlayerName);
            this.Controls.Add(this.lblFirstPlayerName);
            this.Controls.Add(this.lblFirstPlayerInstr);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(551, 669);
            this.Name = "frmMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matchmaker HAHHAHAA";
            this.Load += new System.EventHandler(this.frmMemory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFirstPlayerInstr;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.TextBox txtFirstPlayerName;
        private System.Windows.Forms.Button btnFirstPlayerOK;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.TextBox txtSecondPlayerName;
        private System.Windows.Forms.Button btnSecondPlayerOK;
        private System.Windows.Forms.Label lblInstrTransition;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblNumPoints;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;
    }
}

