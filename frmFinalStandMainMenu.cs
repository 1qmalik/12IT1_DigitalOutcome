using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStand_Version_1._0
{
    public partial class frmFinalStandMainMenu : Form
    {
        string rootResourceDirectory = @"..\..\resources";

        public frmFinalStandMainMenu()
        {
            InitializeComponent();
        }

        private void frmFinalStandMainMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.DarkTurquoise;
            btnPlay.BackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.DarkCyan;
            btnPlay.BackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            /*
            Creates an instance of the Game Creator Forms
            Then it displays it over the main menu
            The main menu is then hidden
            */
            frmFinalStandGameCreationMenu frmGameCreator = new frmFinalStandGameCreationMenu();
            frmGameCreator.Show();
            this.Hide();
        }
    }
}
