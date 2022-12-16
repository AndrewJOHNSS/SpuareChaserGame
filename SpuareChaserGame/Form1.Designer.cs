namespace SpuareChaserGame
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
            this.components = new System.ComponentModel.Container();
            this.pointsPlayer1Label = new System.Windows.Forms.Label();
            this.pointsPlayer2Label = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stupidmodeButton = new System.Windows.Forms.Button();
            this.ohnoButton = new System.Windows.Forms.Button();
            this.verystupidButton = new System.Windows.Forms.Button();
            this.maximumstupidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pointsPlayer1Label
            // 
            this.pointsPlayer1Label.AutoSize = true;
            this.pointsPlayer1Label.BackColor = System.Drawing.Color.Transparent;
            this.pointsPlayer1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointsPlayer1Label.Location = new System.Drawing.Point(240, 9);
            this.pointsPlayer1Label.Name = "pointsPlayer1Label";
            this.pointsPlayer1Label.Size = new System.Drawing.Size(13, 13);
            this.pointsPlayer1Label.TabIndex = 0;
            this.pointsPlayer1Label.Text = "0";
            // 
            // pointsPlayer2Label
            // 
            this.pointsPlayer2Label.AutoSize = true;
            this.pointsPlayer2Label.BackColor = System.Drawing.Color.Transparent;
            this.pointsPlayer2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointsPlayer2Label.Location = new System.Drawing.Point(329, 9);
            this.pointsPlayer2Label.Name = "pointsPlayer2Label";
            this.pointsPlayer2Label.Size = new System.Drawing.Size(13, 13);
            this.pointsPlayer2Label.TabIndex = 1;
            this.pointsPlayer2Label.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winLabel.Location = new System.Drawing.Point(243, 54);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(99, 75);
            this.winLabel.TabIndex = 2;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LawnGreen;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(63, 261);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(89, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY NORMAL";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(243, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stupidmodeButton
            // 
            this.stupidmodeButton.BackColor = System.Drawing.Color.ForestGreen;
            this.stupidmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stupidmodeButton.Location = new System.Drawing.Point(158, 261);
            this.stupidmodeButton.Name = "stupidmodeButton";
            this.stupidmodeButton.Size = new System.Drawing.Size(89, 23);
            this.stupidmodeButton.TabIndex = 5;
            this.stupidmodeButton.Text = "STUPID MODE";
            this.stupidmodeButton.UseVisualStyleBackColor = false;
            this.stupidmodeButton.Click += new System.EventHandler(this.stupidmodeButton_Click);
            // 
            // ohnoButton
            // 
            this.ohnoButton.BackColor = System.Drawing.Color.Gold;
            this.ohnoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohnoButton.Location = new System.Drawing.Point(253, 260);
            this.ohnoButton.Name = "ohnoButton";
            this.ohnoButton.Size = new System.Drawing.Size(89, 23);
            this.ohnoButton.TabIndex = 6;
            this.ohnoButton.Text = "OH NO MODE";
            this.ohnoButton.UseVisualStyleBackColor = false;
            this.ohnoButton.Click += new System.EventHandler(this.ohnoButton_Click);
            // 
            // verystupidButton
            // 
            this.verystupidButton.BackColor = System.Drawing.Color.OrangeRed;
            this.verystupidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verystupidButton.Location = new System.Drawing.Point(348, 259);
            this.verystupidButton.Name = "verystupidButton";
            this.verystupidButton.Size = new System.Drawing.Size(89, 23);
            this.verystupidButton.TabIndex = 8;
            this.verystupidButton.Text = "VERY STUPID MODE";
            this.verystupidButton.UseVisualStyleBackColor = false;
            this.verystupidButton.Click += new System.EventHandler(this.verystupidButton_Click);
            // 
            // maximumstupidButton
            // 
            this.maximumstupidButton.BackColor = System.Drawing.Color.DarkRed;
            this.maximumstupidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumstupidButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maximumstupidButton.Location = new System.Drawing.Point(443, 259);
            this.maximumstupidButton.Name = "maximumstupidButton";
            this.maximumstupidButton.Size = new System.Drawing.Size(89, 23);
            this.maximumstupidButton.TabIndex = 9;
            this.maximumstupidButton.Text = "MAXIMUM STUPID";
            this.maximumstupidButton.UseVisualStyleBackColor = false;
            this.maximumstupidButton.Click += new System.EventHandler(this.maximumstupidButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.maximumstupidButton);
            this.Controls.Add(this.verystupidButton);
            this.Controls.Add(this.ohnoButton);
            this.Controls.Add(this.stupidmodeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.pointsPlayer2Label);
            this.Controls.Add(this.pointsPlayer1Label);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsPlayer1Label;
        private System.Windows.Forms.Label pointsPlayer2Label;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button stupidmodeButton;
        private System.Windows.Forms.Button ohnoButton;
        private System.Windows.Forms.Button verystupidButton;
        private System.Windows.Forms.Button maximumstupidButton;
    }
}

