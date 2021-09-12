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
//The purpose of this code is to tell user that they lost the game and a prompt to either play again or return to man menu

namespace CashCow
{
    public partial class frmLost : Form
    {
        public frmLost()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //restart the game by closing this form and showing the MainGame one
            frmMainGame MainGame = new frmMainGame();
            this.Hide();
            this.Visible = false;
            MainGame.ShowDialog();
            this.Visible = true;
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            //option to return to the main menu, closing this form and showing the MainPage
            frmMainPage MainPage = new frmMainPage();
            this.Hide();
            this.Visible = false;
            MainPage.ShowDialog();
            this.Visible = true;
        }
    }
}
