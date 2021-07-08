using System;

namespace AT2
{
    partial class Board
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.closeGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.button1.Location = new System.Drawing.Point(900, 653);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(898, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Aqua;
            this.Player1.Location = new System.Drawing.Point(24, 762);
            this.Player1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(31, 25);
            this.Player1.TabIndex = 4;
            this.Player1.TabStop = false;
            this.Player1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AT2.Properties.Resources.Board;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(893, 834);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Fuchsia;
            this.Player2.Location = new System.Drawing.Point(24, 800);
            this.Player2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(31, 25);
            this.Player2.TabIndex = 6;
            this.Player2.TabStop = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(912, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 355);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 104);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(905, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player Turn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTurn
            // 
            this.playerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.playerTurn.ForeColor = System.Drawing.Color.Lime;
            this.playerTurn.Location = new System.Drawing.Point(905, 70);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(211, 53);
            this.playerTurn.TabIndex = 10;
            this.playerTurn.Text = "-";
            this.playerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeGame
            // 
            this.closeGame.BackColor = System.Drawing.Color.Magenta;
            this.closeGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeGame.Enabled = false;
            this.closeGame.FlatAppearance.BorderSize = 0;
            this.closeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.closeGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeGame.Location = new System.Drawing.Point(920, 780);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(184, 45);
            this.closeGame.TabIndex = 11;
            this.closeGame.Text = "Close Game";
            this.closeGame.UseVisualStyleBackColor = false;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1128, 837);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Board";
            this.Text = "Snakes and Ladders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.Button closeGame;
    }
}

