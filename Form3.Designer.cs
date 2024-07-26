namespace Paper_Rock_Scissors
{
    partial class Form3
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
            this.playerChoicePBox = new System.Windows.Forms.PictureBox();
            this.computerChoice = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblWinStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerChoicePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // playerChoicePBox
            // 
            this.playerChoicePBox.BackColor = System.Drawing.Color.Transparent;
            this.playerChoicePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerChoicePBox.Image = global::Paper_Rock_Scissors.Properties.Resources.rockLeft_;
            this.playerChoicePBox.Location = new System.Drawing.Point(56, 240);
            this.playerChoicePBox.Name = "playerChoicePBox";
            this.playerChoicePBox.Size = new System.Drawing.Size(596, 240);
            this.playerChoicePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerChoicePBox.TabIndex = 3;
            this.playerChoicePBox.TabStop = false;
            // 
            // computerChoice
            // 
            this.computerChoice.BackColor = System.Drawing.Color.Transparent;
            this.computerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerChoice.Image = global::Paper_Rock_Scissors.Properties.Resources.rockLeft_;
            this.computerChoice.Location = new System.Drawing.Point(799, 240);
            this.computerChoice.Name = "computerChoice";
            this.computerChoice.Size = new System.Drawing.Size(596, 240);
            this.computerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerChoice.TabIndex = 4;
            this.computerChoice.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer.Location = new System.Drawing.Point(242, 131);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(205, 69);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.Color.Lime;
            this.lblComputer.Location = new System.Drawing.Point(951, 131);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(300, 69);
            this.lblComputer.TabIndex = 6;
            this.lblComputer.Text = "Computer";
            // 
            // lblWinStatus
            // 
            this.lblWinStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblWinStatus.Location = new System.Drawing.Point(446, 26);
            this.lblWinStatus.Name = "lblWinStatus";
            this.lblWinStatus.Size = new System.Drawing.Size(583, 82);
            this.lblWinStatus.TabIndex = 7;
            this.lblWinStatus.Text = "Won";
            this.lblWinStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1490, 572);
            this.Controls.Add(this.lblWinStatus);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.computerChoice);
            this.Controls.Add(this.playerChoicePBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.lblRound, 0);
            this.Controls.SetChildIndex(this.playerChoicePBox, 0);
            this.Controls.SetChildIndex(this.computerChoice, 0);
            this.Controls.SetChildIndex(this.lblPlayer, 0);
            this.Controls.SetChildIndex(this.lblComputer, 0);
            this.Controls.SetChildIndex(this.lblWinStatus, 0);
            this.Controls.SetChildIndex(this.lblTimer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.playerChoicePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerChoicePBox;
        private System.Windows.Forms.PictureBox computerChoice;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblWinStatus;
    }
}