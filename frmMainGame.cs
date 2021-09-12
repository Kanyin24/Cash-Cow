using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

//Kanyinsola Adejola
//Thursday Janurary 28, 2021
//The purpose of this class/code is to connect the user interaction with the code of the objects (bricks and wall) using wands to create a Cash Cow game

namespace CashCow
{
    public partial class frmMainGame : Form
    {
        //global variable
        Wall oWall;
        //int Track = 0;
        int WandCount = 0;
        int OldHighScore = 0;

        public frmMainGame()
        {
            InitializeComponent();
        }

        private void frmMainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartGame();
            }
            
            this.Refresh();
        }

        private void frmMainGame_Paint(object sender, PaintEventArgs e)
        {
            if (oWall != null)
            {
                oWall.Draw(this.CreateGraphics(), 410, 130);
            }
        }

        private void frmMainGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (oWall != null)
            {
                //lblContinue.Visible = false;
                int X = e.X;
                int Y = e.Y;

                if (X >= 410 && Y >= 130 || X <= 810 && Y <= 530)
                {
                    X = (X - 410) / 25;
                    Y = (Y - 130) / 25;


                    if (X > -1 && Y > -1 && X < 16 && Y < 16)
                    {
                        if (oWall.WandState != true)
                            oWall.CountFill = 0;

                        if (oWall.WandState == true)
                            oWall.CountFill++;

                        oWall.FirstBrickClick = (Y, X);
                        oWall.FloodBricks(X, Y);
                        oWall.MakeBrickTransparent();

                    }

                }

                this.Refresh();
            }
            if (lblContinue.Visible == true)
            {
                lblContinue.Visible = false;
                ContinueGame();
            }

        }

        private void StartGame()
        {
            oWall = new Wall(16, 16);
            lblEnter.Visible = false;


            tmrGame.Enabled = true;

            Random Rando = new Random();
            Rando = new Random();

            int Random = Rando.Next(0, 99999);
            for (int i = 0; i < Random; i++)
            {
                oWall.Shuffle();
            }

            DisplayItems();
        }
        private void DisplayItems()
        {
            //display items on screen when game starts
            picWand1.Visible = true;
            picWand2.Visible = true;
            picWand3.Visible = true;
            picWand4.Visible = true;
            picWand5.Visible = true;
            lblCowCash.Visible = true;
            lblScore.Visible = true;
        }

        private void PicWand1_Click(object sender, EventArgs e)
        {
            //enable wand 1
            oWall.WandState = true;
            picWand1.Visible = false;
            WandCount++;
        }

        private void picWand2_Click(object sender, EventArgs e)
        {
            //enable wand 2
            oWall.WandState = true;
            picWand2.Visible = false;
            WandCount++;
        }

        private void picWand3_Click(object sender, EventArgs e)
        {
            //enable wand 3
            oWall.WandState = true;
            picWand3.Visible = false;
            WandCount++;
        }

        private void picWand4_Click(object sender, EventArgs e)
        {
            //enable wand 4
            oWall.WandState = true;
            picWand4.Visible = false;
            WandCount++;
        }

        private void picWand5_Click(object sender, EventArgs e)
        {
            //enable wand 5
            oWall.WandState = true;
            picWand5.Visible = false;
            WandCount++;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            oWall.TrackResizeWallBricks();
            oWall.ResizeWall();
            oWall.TrackingGame();
            oWall.CheckForNoMatches();

            if (oWall.Track != 0 && oWall != null)
            {
                oWall.ScoreUpdate();

                lblScore.Text = "Score : " + oWall.Score;
                oWall.MatchedBricks = 0;
                oWall.Track = 0;

                
                if (oWall.WandState == true)
                {
                    oWall.ResizeWall();
                }
                //continue game when grid is empty but wands are not finished 
                if (oWall.CountAllTransparentBricks == 0 && WandCount < 5)
                {
                    oWall.ContinueGame = true;
                    OldHighScore = oWall.Score + OldHighScore;
                    oWall.OldHighScore = OldHighScore;
                    PauseContinueGame();
                }
                //win game when grid is emptied and wands are finished at the same time
                else if (oWall.CountAllTransparentBricks == 0 && WandCount == 5)
                {
                    OldHighScore = oWall.Score;
                    oWall.OldHighScore = OldHighScore;
                    WinGame();
                }
                //lose game when wands are finished but grid is not empty
                else if (oWall.CountAllTransparentBricks != 0 && WandCount == 5 && oWall.EndGame == true)
                {
                    OldHighScore = oWall.Score;
                    oWall.OldHighScore = OldHighScore;
                    LostGame();
                }

            }

        }

        public void WinGame()
        {
            //method to end game when won and show win game form
            tmrGame.Enabled = false;
            lblHighScore.Visible = true;
            lblHighScore.Text = "High Score: " + OldHighScore;
            oWall = null;

            Thread.Sleep(500);
            this.Hide();
            frmWonGame WonGame = new frmWonGame();
            this.Visible = false;
            WonGame.ShowDialog();
            this.Visible = true;
        }
        
        public void PauseContinueGame()
        {
            //method to continue game when grid is empty but wands aren't finished 
            lblContinue.Visible = true;
            tmrGame.Enabled = false;
            oWall = null;
        }

        public void LostGame()
        {
            //method to end game and display lose form
            tmrGame.Enabled = false;
            lblHighScore.Visible = true;
            lblHighScore.Text = "High Score: " + OldHighScore;
            oWall = null;

            Thread.Sleep(500);
            this.Hide();
            frmLost EndGame = new frmLost();
            this.Visible = false;
            EndGame.ShowDialog();
            this.Visible = true;

        }
        public void ContinueGame()
        {
            //redrawing the grid on the screen to continue game
            oWall = new Wall(16, 16);

            tmrGame.Enabled = true;

            Random Rando = new Random();
            Rando = new Random();

            int Random = Rando.Next(0, 99000);
            for (int i = 0; i < Random; i++)
            {
                oWall.Shuffle();
            }
            
            oWall.ContinueGame = true;
            lblHighScore.Visible = true;
            lblHighScore.Text = "High Score: " + OldHighScore;
        }
    }
}
