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
            this.TwoPlayer = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.Button();
            this.OnePlayer = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-1, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snakes And Ladders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TwoPlayer
            // 
            this.TwoPlayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoPlayer.BackgroundImage = global::AT2.Properties.Resources.One;
            this.TwoPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TwoPlayer.Location = new System.Drawing.Point(12, 153);
            this.TwoPlayer.Name = "TwoPlayer";
            this.TwoPlayer.Size = new System.Drawing.Size(68, 68);
            this.TwoPlayer.TabIndex = 2;
            this.TwoPlayer.UseVisualStyleBackColor = false;
            this.TwoPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Transparent;
            this.Connect.BackgroundImage = global::AT2.Properties.Resources.ONline;
            this.Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Connect.Location = new System.Drawing.Point(371, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(91, 92);
            this.Connect.TabIndex = 5;
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AT2.Properties.Resources.Play;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 73);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(12, 519);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(83, 70);
            this.Settings.TabIndex = 6;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.button6_Click);
            // 
            // OnePlayer
            // 
            this.OnePlayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OnePlayer.BackgroundImage = global::AT2.Properties.Resources.one1;
            this.OnePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.OnePlayer.Location = new System.Drawing.Point(12, 91);
            this.OnePlayer.Name = "OnePlayer";
            this.OnePlayer.Size = new System.Drawing.Size(56, 56);
            this.OnePlayer.TabIndex = 1;
            this.OnePlayer.UseVisualStyleBackColor = false;
            this.OnePlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loadButton.Location = new System.Drawing.Point(12, 466);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(83, 47);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = global::AT2.Properties.Resources.Main_Menu_Pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 632);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.TwoPlayer);
            this.Controls.Add(this.OnePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snakes and Ladders";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OnePlayer;
        private System.Windows.Forms.Button TwoPlayer;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loadButton;
    }
}