using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpuareChaserGame
{
    public partial class Form1 : Form
    {
        Random randgen = new Random();

        Rectangle player1 = new Rectangle(50, 200, 20, 20);
        Rectangle player2 = new Rectangle(550, 200, 20, 20);
        Rectangle point = new Rectangle(175, 200, 10, 10);
        Rectangle speed = new Rectangle(345, 350, 10, 10);
        Rectangle losepoint = new Rectangle(186, 100, 18, 18);
        Rectangle border = new Rectangle(5, 5, 600, 400);

        int player1Score = 0;
        int player2Score = 0;

        SoundPlayer playerbleep = new SoundPlayer(Properties.Resources.Bleep_SoundBible_com_1927126940);
        SoundPlayer playerBWOWWW = new SoundPlayer(Properties.Resources.foghorn_daniel_simon);
        SoundPlayer playerHONK = new SoundPlayer(Properties.Resources.Horn_Honk_SoundBible_com_1634776698);
        SoundPlayer playerSOS = new SoundPlayer(Properties.Resources.sos_morse_code_daniel_simion);

        int pointXSpeed = -3;
        int pointYSpeed = -5;
        int speedXSpeed = 9;
        int speedYSpeed = 8;
        int losepointXSpeed = 7;
        int losepointYSpeed = 5;

        int maxscore = 5;

        int player1Speed = 4;
        int player2Speed = 4;

        string gameState = "Starting";

        bool wDown = false;
        bool sDown = false;
        bool dDown = false;
        bool aDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush pinkBrush = new SolidBrush(Color.Pink);
        Pen drawpen = new Pen(Color.MediumVioletRed, 5);
        public Form1()
        {
            InitializeComponent();
            playButton.Enabled = true;
            exitButton.Enabled = true;
            stupidmodeButton.Enabled = true;
            ohnoButton.Enabled = true;
            verystupidButton.Enabled = true;
            maximumstupidButton.Enabled = true;
            gameState = "Starting";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(greenBrush, player2);
            e.Graphics.FillRectangle(yellowBrush, speed);
            e.Graphics.FillRectangle(whiteBrush, point);
            e.Graphics.FillRectangle(pinkBrush, losepoint);
            e.Graphics.DrawRectangle(drawpen, 0, 0, 600, 400);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameState = "Running";
            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }
            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }

            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            // check score and stop game if either player is at 10
            if (player1Score == (maxscore))
            {
                playerHONK.Play();
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Gameover: Player 1 Wins!!";
                this.Refresh();
                Thread.Sleep(4000);
                winLabel.Text = "play again?";
                playerBWOWWW.Play();
                this.Refresh();
                Thread.Sleep(400);
                playerBWOWWW.Play();
                gameState = "Over";
                gameTimer.Enabled = false;
            }
            else if (player2Score == (maxscore))
            {
                playerSOS.Play();
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Gameover: Player 2 Wins!!";
                this.Refresh();
                Thread.Sleep(4000);
                winLabel.Text = "play again?";
                playerBWOWWW.Play();
                this.Refresh();
                Thread.Sleep(400);
                playerBWOWWW.Play();
                gameState = "Over";
                gameTimer.Enabled = false;
            }

            //if you hit point you gain point
            if (player1.IntersectsWith(point))
            {
                int x = randgen.Next(0, 580);
                int y = randgen.Next(0, 380);
                point.X = x;
                point.Y = y;
                player1Score++;
                pointsPlayer1Label.Text = $"{player1Score}";
                playerbleep.Play();
            }
            if (player2.IntersectsWith(point))
            {
                int x = randgen.Next(0, 580);
                int y = randgen.Next(0, 380);
                point.X = x;
                point.Y = y;
                player2Score++;
                pointsPlayer2Label.Text = $"{player2Score}";
                playerbleep.Play();
            }
            //if you hit speed, speed increases
            if (player1.IntersectsWith(speed))
            {
                int xspeed = randgen.Next(0, 580);
                int yspeed = randgen.Next(0, 380);
                speed.X = xspeed;
                speed.Y = yspeed;
                player1Speed++;
                playerbleep.Play();
            }
            if (player2.IntersectsWith(speed))
            {
                int xspeed = randgen.Next(0, 580);
                int yspeed = randgen.Next(0, 380);
                speed.X = xspeed;
                speed.Y = yspeed;
                player2Speed++;
                playerbleep.Play();
            }
            if (player1.IntersectsWith(losepoint))
            {
                int xlose = randgen.Next(0, 560);
                int ylose = randgen.Next(0, 360);
                losepoint.X = xlose;
                losepoint.Y = ylose;
                player1Score--;
                player1Speed--;
                pointsPlayer1Label.Text = $"{player1Score}";
            }
            if (player2.IntersectsWith(losepoint))
            {
                int xlose = randgen.Next(0, 560);
                int ylose = randgen.Next(0, 360);
                losepoint.X = xlose;
                losepoint.Y = ylose;
                player2Score--;
                player2Speed--;
                pointsPlayer2Label.Text = $"{player2Score}";
            }
            //move point all over the place
            point.X += pointXSpeed;
            point.Y += pointYSpeed;

            if (point.Y < 0 || point.Y > this.Height - point.Height)
            {
                pointYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }
            if (point.Y > 400)
            {
                pointYSpeed *= -1;
            }
            if (point.X < 0)
            {
                pointXSpeed *= -1;
            }
            else if (point.X > 600)
            {
                pointXSpeed *= -1;
            }

            //move speed all over the place
            speed.X += speedXSpeed;
            speed.Y += speedYSpeed;

            if (speed.Y < 0 || speed.Y > this.Height - speed.Height)
            {
                speedYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }
            if (speed.Y > 400)
            {
                speedYSpeed *= -1;
            }
            if (speed.X < 0)
            {
                speedXSpeed *= -1;
            }
            else if (speed.X > 600)
            {
                speedXSpeed *= -1;
            }

            losepoint.X += losepointXSpeed;
            losepoint.Y += losepointYSpeed;

            if (losepoint.Y < 0 || losepoint.Y > this.Height - losepoint.Height)
            {
                losepointYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }
            if (losepoint.Y > 390)
            {
                losepointYSpeed *= -1;
            }
            if (losepoint.X < 0)
            {
                losepointXSpeed *= -1;
            }
            else if (losepoint.X > 590)
            {
                losepointXSpeed *= -1;
            }

            if (gameState == "Over")
            {
                playButton.Enabled = true;
                exitButton.Enabled = true;
                playButton.Visible = true;
                exitButton.Visible = true;
                stupidmodeButton.Enabled = true;
                stupidmodeButton.Visible = true;
                ohnoButton.Enabled = true;
                ohnoButton.Visible = true;
                verystupidButton.Enabled = true;
                verystupidButton.Visible = true;
                maximumstupidButton.Visible = true;
                maximumstupidButton.Enabled = true;
                gameTimer.Stop();
            }
            else if (gameState == "Running")
            {
                playButton.Enabled = false;
                exitButton.Enabled = false;
                playButton.Visible = false;
                exitButton.Visible = false;
                stupidmodeButton.Enabled = false;
                stupidmodeButton.Visible = false;
                ohnoButton.Enabled = false;
                ohnoButton.Visible = false;
                verystupidButton.Enabled = false;
                verystupidButton.Visible = false;
                maximumstupidButton.Visible = false;
                maximumstupidButton.Enabled = false;
                gameTimer.Start();
            }

            Refresh();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            pointXSpeed = -3;
            pointYSpeed = -5;
            player1Speed = 4;
            player2Speed = 4;
            player1Score = 0;
            player2Score = 0;
            losepointXSpeed = 5;
            losepointYSpeed = 5;
            maxscore = 5;
            player1.X = 50;
            player1.Y = 200;
            player2.X = 550;
            player2.Y = 200;
            gameState = "Running";
            gameTimer.Start();
            playButton.Enabled = false;
            exitButton.Enabled = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            stupidmodeButton.Enabled = false;
            stupidmodeButton.Visible = false;
            ohnoButton.Enabled = false;
            ohnoButton.Visible = false;
            verystupidButton.Enabled = false;
            verystupidButton.Visible = false;
            maximumstupidButton.Visible = false;
            maximumstupidButton.Enabled = false;
            winLabel.Text = "";
            this.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stupidmodeButton_Click(object sender, EventArgs e)
        {
            pointXSpeed = -3;
            pointYSpeed = -5;
            player1Speed = 40;
            player2Speed = 40;
            maxscore = 50;
            losepointXSpeed = 20;
            losepointYSpeed = 15;
            player1Score = 0;
            player2Score = 0;
            player1.X = 50;
            player1.Y = 200;
            player2.X = 550;
            player2.Y = 200;
            gameState = "Running";
            gameTimer.Start();
            playButton.Enabled = false;
            exitButton.Enabled = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            stupidmodeButton.Enabled = false;
            stupidmodeButton.Visible = false;
            ohnoButton.Enabled = false;
            ohnoButton.Visible = false;
            verystupidButton.Enabled = false;
            verystupidButton.Visible = false;
            maximumstupidButton.Visible = false;
            maximumstupidButton.Enabled = false;
            winLabel.Text = "FIRST TO 50 WINS!";
            this.Refresh();
            Thread.Sleep(10);
            this.Focus();
        }

        private void ohnoButton_Click(object sender, EventArgs e)
        {
            pointXSpeed = -3;
            pointYSpeed = -5;
            player1Speed = 90;
            player2Speed = 90;
            maxscore = 100;
            losepointXSpeed = 30;
            losepointYSpeed = 25;
            player1Score = 0;
            player2Score = 0;
            player1.X = 50;
            player1.Y = 200;
            player2.X = 550;
            player2.Y = 200;
            gameState = "Running";
            gameTimer.Start();
            playButton.Enabled = false;
            exitButton.Enabled = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            stupidmodeButton.Enabled = false;
            stupidmodeButton.Visible = false;
            ohnoButton.Enabled = false;
            ohnoButton.Visible = false;
            verystupidButton.Enabled = false;
            verystupidButton.Visible = false;
            maximumstupidButton.Visible = false;
            maximumstupidButton.Enabled = false;
            winLabel.Text = "FIRST TO 100 WINS!";
            this.Refresh();
            Thread.Sleep(10);
            this.Focus();
        }

        private void verystupidButton_Click(object sender, EventArgs e)
        {
            pointXSpeed = -3;
            pointYSpeed = -5;
            player1Speed = 120;
            player2Speed = 120;
            maxscore = 200;
            losepointXSpeed = 35;
            losepointYSpeed = 30;
            player1Score = 0;
            player2Score = 0;
            player1.X = 50;
            player1.Y = 200;
            player2.X = 550;
            player2.Y = 200;
            gameState = "Running";
            gameTimer.Start();
            playButton.Enabled = false;
            exitButton.Enabled = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            stupidmodeButton.Enabled = false;
            stupidmodeButton.Visible = false;
            ohnoButton.Enabled = false;
            ohnoButton.Visible = false;
            verystupidButton.Enabled = false;
            verystupidButton.Visible = false;
            maximumstupidButton.Visible = false;
            maximumstupidButton.Enabled = false;
            winLabel.Text = "FIRST TO 200 WINS!";
            this.Refresh();
            Thread.Sleep(10);
            this.Focus();
        }

        private void maximumstupidButton_Click(object sender, EventArgs e)
        {
            player1Speed = 1;
            player2Speed = 1;
            maxscore = 1000000;
            losepointXSpeed = 41;
            losepointYSpeed = 40;
            pointXSpeed = -5;
            pointYSpeed = -9;
            player1Score = 0;
            player2Score = 0;
            player1.X = 50;
            player1.Y = 200;
            player2.X = 550;
            player2.Y = 200;
            gameState = "Running";
            gameTimer.Start();
            playButton.Enabled = false;
            exitButton.Enabled = false;
            playButton.Visible = false;
            exitButton.Visible = false;
            stupidmodeButton.Enabled = false;
            stupidmodeButton.Visible = false;
            ohnoButton.Enabled = false;
            ohnoButton.Visible = false;
            verystupidButton.Enabled = false;
            verystupidButton.Visible = false;
            maximumstupidButton.Visible = false;
            maximumstupidButton.Enabled = false;
            winLabel.Text = "FIRST TO 1,000,000 WINS!";
            this.Refresh();
            Thread.Sleep(10);
            this.Focus();
        }
    }
}