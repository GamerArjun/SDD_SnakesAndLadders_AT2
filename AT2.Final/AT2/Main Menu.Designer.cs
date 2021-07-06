namespace AT2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.OnePlayer = new System.Windows.Forms.Button();
            this.TwoPlayer = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snakes And Ladders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OnePlayer
            // 
            this.OnePlayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.OnePlayer.Location = new System.Drawing.Point(898, 12);
            this.OnePlayer.Name = "OnePlayer";
            this.OnePlayer.Size = new System.Drawing.Size(184, 123);
            this.OnePlayer.TabIndex = 1;
            this.OnePlayer.Text = "One Player";
            this.OnePlayer.UseVisualStyleBackColor = false;
            this.OnePlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // TwoPlayer
            // 
            this.TwoPlayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TwoPlayer.Location = new System.Drawing.Point(898, 141);
            this.TwoPlayer.Name = "TwoPlayer";
            this.TwoPlayer.Size = new System.Drawing.Size(184, 123);
            this.TwoPlayer.TabIndex = 2;
            this.TwoPlayer.Text = "Two Player";
            this.TwoPlayer.UseVisualStyleBackColor = false;
            this.TwoPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Connect.Location = new System.Drawing.Point(12, 433);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(200, 123);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect Online";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.button5_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(13, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(83, 70);
            this.Settings.TabIndex = 6;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 568);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.TwoPlayer);
            this.Controls.Add(this.OnePlayer);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Snakes and Ladders";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OnePlayer;
        private System.Windows.Forms.Button TwoPlayer;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Settings;
    }
}