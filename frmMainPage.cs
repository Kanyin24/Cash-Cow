using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCow
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainGame row = new frmMainGame();
            this.Visible = false;
            row.ShowDialog();
            this.Visible = true;
        }

        private void lblInstruc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInstruc row = new frmInstruc();
            this.Visible = false;
            row.ShowDialog();
            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
