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

        private void btnControls_MouseEnter(object sender, EventArgs e)
        {
            btnControls.ForeColor = Color.DarkTurquoise;
            btnControls.BackColor = Color.Transparent;
            btnControls.FlatStyle = FlatStyle.Flat;
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

        private void btnControls_MouseLeave(object sender, EventArgs e)
        {
            btnControls.ForeColor = Color.DarkCyan;
            btnControls.BackColor = Color.Transparent;
            btnControls.FlatStyle = FlatStyle.Flat;
        }
    }
}
