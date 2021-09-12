using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kanyinsola Adejola
//Thursday Janurary 28, 2021
//The purpose of this code is to tell user that they won the game and a prompt to either play again or return to man menu

namespace CashCow
{
    public partial class frmWonGame : Form
    {
        public frmWonGame()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //restart the game by closing this form and showing the MainGame one
            this.Hide();
            frmMainGame MainGame = new frmMainGame();
            this.Visible = false;
            MainGame.ShowDialog();
            this.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //option to return to the main menu, closing this form and showing the MainPage
            this.Hide();
            frmMainPage MainPage = new frmMainPage();
            this.Visible = false;
            MainPage.ShowDialog();
            this.Visible = true;
        }
    }
}
