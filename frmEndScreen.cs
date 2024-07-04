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
    public partial class frmEndScreen : Form
    {
        public frmEndScreen(int score, string status)
        {
            InitializeComponent();
            lblScore.Text = "Final Score: " + score.ToString();
            lblStatus.Text = "You " + status;
        }
    }
}
