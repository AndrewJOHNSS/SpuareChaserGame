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
            this.gameTimer.Enabled = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 400);
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
    }
}

