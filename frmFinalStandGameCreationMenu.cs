using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStand
{
    public partial class frmFinalStandGameCreationMenu : Form
    {
        const string maps = @"resources\maps\";
        public frmFinalStandGameCreationMenu()
        {
            InitializeComponent();
        }

        private void frmFinalStandGameCreationMenu_Load(object sender, EventArgs e)
        {
            cmbMap.SelectedIndex = 0;
        }

        private void frmFinalStandGameCreationMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGame frmGameWindow = new frmGame(cmbMap.SelectedItem.ToString());
            frmGameWindow.ShowDialog();
            this.Close();
        }
    }
}
