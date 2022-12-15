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
            this.SuspendLayout();
            // 
            // pointsPlayer1Label
            // 
            this.pointsPlayer1Label.AutoSize = true;
            this.pointsPlayer1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointsPlayer1Label.Location = new System.Drawing.Point(236, 9);
            this.pointsPlayer1Label.Name = "pointsPlayer1Label";
            this.pointsPlayer1Label.Size = new System.Drawing.Size(13, 13);
            this.pointsPlayer1Label.TabIndex = 0;
            this.pointsPlayer1Label.Text = "0";
            // 
            // pointsPlayer2Label
            // 
            this.pointsPlayer2Label.AutoSize = true;
            this.pointsPlayer2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointsPlayer2Label.Location = new System.Drawing.Point(315, 9);
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
            this.winLabel.AutoSize = true;
            this.winLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winLabel.Location = new System.Drawing.Point(274, 54);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 13);
            this.winLabel.TabIndex = 2;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(185, 261);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(89, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stupidmodeButton
            // 
            this.stupidmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stupidmodeButton.Location = new System.Drawing.Point(296, 261);
            this.stupidmodeButton.Name = "stupidmodeButton";
            this.stupidmodeButton.Size = new System.Drawing.Size(89, 23);
            this.stupidmodeButton.TabIndex = 5;
            this.stupidmodeButton.Text = "STUPID MODE";
            this.stupidmodeButton.UseVisualStyleBackColor = true;
            this.stupidmodeButton.Click += new System.EventHandler(this.stupidmodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.stupidmodeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.pointsPlayer2Label);
            this.Controls.Add(this.pointsPlayer1Label);
            this.DoubleBuffered = true;
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
    }
}

