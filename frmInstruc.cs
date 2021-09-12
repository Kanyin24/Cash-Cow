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
//The purpose of this form is to explain the instructions of the game to the user
namespace CashCow
{
    public partial class frmInstruc : Form
    {
        public frmInstruc()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
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
