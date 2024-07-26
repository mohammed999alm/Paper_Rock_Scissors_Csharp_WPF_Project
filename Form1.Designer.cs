namespace Paper_Rock_Scissors
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnRightChoice = new System.Windows.Forms.Button();
            this.btnLeftChoice = new System.Windows.Forms.Button();
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoundRightArrow = new System.Windows.Forms.Button();
            this.lblRoundChoice = new System.Windows.Forms.Label();
            this.btnRoundLeftArrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.DimGray;
            this.btnStartGame.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnStartGame.Location = new System.Drawing.Point(600, 730);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(320, 54);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnRightChoice
            // 
            this.btnRightChoice.BackColor = System.Drawing.Color.Black;
            this.btnRightChoice.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightChoice.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRightChoice.Location = new System.Drawing.Point(288, 759);
            this.btnRightChoice.Name = "btnRightChoice";
            this.btnRightChoice.Size = new System.Drawing.Size(46, 42);
            this.btnRightChoice.TabIndex = 7;
            this.btnRightChoice.Text = ">";
            this.btnRightChoice.UseVisualStyleBackColor = false;
            this.btnRightChoice.Click += new System.EventHandler(this.btnRightChoice_Click);
            // 
            // btnLeftChoice
            // 
            this.btnLeftChoice.BackColor = System.Drawing.Color.Black;
            this.btnLeftChoice.Enabled = false;
            this.btnLeftChoice.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftChoice.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLeftChoice.Location = new System.Drawing.Point(21, 759);
            this.btnLeftChoice.Name = "btnLeftChoice";
            this.btnLeftChoice.Size = new System.Drawing.Size(46, 42);
            this.btnLeftChoice.TabIndex = 8;
            this.btnLeftChoice.Text = "<";
            this.btnLeftChoice.UseVisualStyleBackColor = false;
            this.btnLeftChoice.Click += new System.EventHandler(this.btnLeftChoice_Click);
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.BackColor = System.Drawing.Color.Black;
            this.lblTimeLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLimit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTimeLimit.Location = new System.Drawing.Point(73, 759);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(209, 42);
            this.lblTimeLimit.TabIndex = 9;
            this.lblTimeLimit.Text = "Unlimited";
            this.lblTimeLimit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(25, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time Limit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(1118, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rounds :";
            // 
            // btnRoundRightArrow
            // 
            this.btnRoundRightArrow.BackColor = System.Drawing.Color.Black;
            this.btnRoundRightArrow.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundRightArrow.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRoundRightArrow.Location = new System.Drawing.Point(1382, 757);
            this.btnRoundRightArrow.Name = "btnRoundRightArrow";
            this.btnRoundRightArrow.Size = new System.Drawing.Size(46, 42);
            this.btnRoundRightArrow.TabIndex = 13;
            this.btnRoundRightArrow.Text = ">";
            this.btnRoundRightArrow.UseVisualStyleBackColor = false;
            this.btnRoundRightArrow.Click += new System.EventHandler(this.btnRoundRightArrow_Click);
            // 
            // lblRoundChoice
            // 
            this.lblRoundChoice.BackColor = System.Drawing.Color.Black;
            this.lblRoundChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoundChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRoundChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundChoice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRoundChoice.Location = new System.Drawing.Point(1167, 757);
            this.lblRoundChoice.Name = "lblRoundChoice";
            this.lblRoundChoice.Size = new System.Drawing.Size(209, 42);
            this.lblRoundChoice.TabIndex = 14;
            this.lblRoundChoice.Text = "Unlimited";
            this.lblRoundChoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRoundLeftArrow
            // 
            this.btnRoundLeftArrow.BackColor = System.Drawing.Color.Black;
            this.btnRoundLeftArrow.Enabled = false;
            this.btnRoundLeftArrow.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundLeftArrow.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRoundLeftArrow.Location = new System.Drawing.Point(1115, 757);
            this.btnRoundLeftArrow.Name = "btnRoundLeftArrow";
            this.btnRoundLeftArrow.Size = new System.Drawing.Size(46, 42);
            this.btnRoundLeftArrow.TabIndex = 15;
            this.btnRoundLeftArrow.Text = "<";
            this.btnRoundLeftArrow.UseVisualStyleBackColor = false;
            this.btnRoundLeftArrow.Click += new System.EventHandler(this.btnRoundLeftArrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paper_Rock_Scissors.Properties.Resources.rockpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1453, 819);
            this.Controls.Add(this.btnRoundLeftArrow);
            this.Controls.Add(this.lblRoundChoice);
            this.Controls.Add(this.btnRoundRightArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeLimit);
            this.Controls.Add(this.btnLeftChoice);
            this.Controls.Add(this.btnRightChoice);
            this.Controls.Add(this.btnStartGame);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnRightChoice;
        private System.Windows.Forms.Button btnLeftChoice;
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoundRightArrow;
        private System.Windows.Forms.Label lblRoundChoice;
        private System.Windows.Forms.Button btnRoundLeftArrow;
    }
}

