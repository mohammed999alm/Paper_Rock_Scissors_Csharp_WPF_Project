namespace Paper_Rock_Scissors
{
    partial class Form2
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
            this.playerRockChoicePBox = new System.Windows.Forms.PictureBox();
            this.playerPaperChoicePBox = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.PlayerScissorsPBox = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.btnEndGameSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockChoicePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperChoicePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerScissorsPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // playerRockChoicePBox
            // 
            this.playerRockChoicePBox.BackColor = System.Drawing.Color.Transparent;
            this.playerRockChoicePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerRockChoicePBox.Image = global::Paper_Rock_Scissors.Properties.Resources.rockLeft_;
            this.playerRockChoicePBox.Location = new System.Drawing.Point(136, 89);
            this.playerRockChoicePBox.Name = "playerRockChoicePBox";
            this.playerRockChoicePBox.Size = new System.Drawing.Size(396, 240);
            this.playerRockChoicePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerRockChoicePBox.TabIndex = 2;
            this.playerRockChoicePBox.TabStop = false;
            // 
            // playerPaperChoicePBox
            // 
            this.playerPaperChoicePBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPaperChoicePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPaperChoicePBox.Image = global::Paper_Rock_Scissors.Properties.Resources.paperLeft_;
            this.playerPaperChoicePBox.Location = new System.Drawing.Point(638, 437);
            this.playerPaperChoicePBox.Name = "playerPaperChoicePBox";
            this.playerPaperChoicePBox.Size = new System.Drawing.Size(396, 240);
            this.playerPaperChoicePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPaperChoicePBox.TabIndex = 3;
            this.playerPaperChoicePBox.TabStop = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblChoose.Location = new System.Drawing.Point(716, 22);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(201, 46);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Choose : ";
            // 
            // PlayerScissorsPBox
            // 
            this.PlayerScissorsPBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScissorsPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerScissorsPBox.Image = global::Paper_Rock_Scissors.Properties.Resources.ScissorsLeft;
            this.PlayerScissorsPBox.Location = new System.Drawing.Point(1108, 89);
            this.PlayerScissorsPBox.Name = "PlayerScissorsPBox";
            this.PlayerScissorsPBox.Size = new System.Drawing.Size(396, 240);
            this.PlayerScissorsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerScissorsPBox.TabIndex = 5;
            this.PlayerScissorsPBox.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.BackgroundImage = global::Paper_Rock_Scissors.Properties.Resources.rockLabel_removebg_preview;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.ForeColor = System.Drawing.Color.Transparent;
            this.btnRock.Location = new System.Drawing.Point(136, 355);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(396, 67);
            this.btnRock.TabIndex = 6;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Transparent;
            this.btnScissors.BackgroundImage = global::Paper_Rock_Scissors.Properties.Resources.ScissorsLabel_removebg_preview;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissors.ForeColor = System.Drawing.Color.Transparent;
            this.btnScissors.Location = new System.Drawing.Point(1108, 355);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(396, 67);
            this.btnScissors.TabIndex = 7;
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.BackgroundImage = global::Paper_Rock_Scissors.Properties.Resources.paperLabel_removebg_preview;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaper.Location = new System.Drawing.Point(638, 706);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(396, 67);
            this.btnPaper.TabIndex = 8;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblWon.Location = new System.Drawing.Point(169, 500);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(153, 42);
            this.lblWon.TabIndex = 9;
            this.lblWon.Text = "Won : 0";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLose.Location = new System.Drawing.Point(174, 570);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(148, 42);
            this.lblLose.TabIndex = 10;
            this.lblLose.Text = "Lost : 0";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDraw.Location = new System.Drawing.Point(169, 647);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(164, 42);
            this.lblDraw.TabIndex = 11;
            this.lblDraw.Text = "Draw : 0";
            // 
            // btnEndGameSession
            // 
            this.btnEndGameSession.BackColor = System.Drawing.Color.Transparent;
            this.btnEndGameSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndGameSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGameSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGameSession.ForeColor = System.Drawing.Color.Transparent;
            this.btnEndGameSession.Location = new System.Drawing.Point(136, 773);
            this.btnEndGameSession.Name = "btnEndGameSession";
            this.btnEndGameSession.Size = new System.Drawing.Size(396, 67);
            this.btnEndGameSession.TabIndex = 12;
            this.btnEndGameSession.Text = "End Game Here";
            this.btnEndGameSession.UseVisualStyleBackColor = false;
            this.btnEndGameSession.Click += new System.EventHandler(this.btnEndGameSession_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1634, 1055);
            this.Controls.Add(this.btnEndGameSession);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.PlayerScissorsPBox);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.playerPaperChoicePBox);
            this.Controls.Add(this.playerRockChoicePBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Leave += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.lblRound, 0);
            this.Controls.SetChildIndex(this.lblTimer, 0);
            this.Controls.SetChildIndex(this.playerRockChoicePBox, 0);
            this.Controls.SetChildIndex(this.playerPaperChoicePBox, 0);
            this.Controls.SetChildIndex(this.lblChoose, 0);
            this.Controls.SetChildIndex(this.PlayerScissorsPBox, 0);
            this.Controls.SetChildIndex(this.btnRock, 0);
            this.Controls.SetChildIndex(this.btnScissors, 0);
            this.Controls.SetChildIndex(this.btnPaper, 0);
            this.Controls.SetChildIndex(this.lblWon, 0);
            this.Controls.SetChildIndex(this.lblLose, 0);
            this.Controls.SetChildIndex(this.lblDraw, 0);
            this.Controls.SetChildIndex(this.btnEndGameSession, 0);
            ((System.ComponentModel.ISupportInitialize)(this.playerRockChoicePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperChoicePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerScissorsPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox playerRockChoicePBox;
        private System.Windows.Forms.PictureBox playerPaperChoicePBox;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.PictureBox PlayerScissorsPBox;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Button btnEndGameSession;
        //private System.Windows.Forms.Timer timer1;
    }
}