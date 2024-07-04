﻿using System;
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
    public partial class frmFinalStandMainMenu : Form
    {
        string rootResourceDirectory = "resources";

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
            this.Hide();
            frmFinalStandGameCreationMenu frmGameCreator = new frmFinalStandGameCreationMenu();
            frmGameCreator.ShowDialog();
            this.Close();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            frmTutorial tutorial = new frmTutorial();
            tutorial.ShowDialog();
        }

        private void btnTutorial_MouseEnter(object sender, EventArgs e)
        {
            btnTutorial.ForeColor = Color.DarkTurquoise;
            btnTutorial.BackColor = Color.Transparent;
            btnTutorial.FlatStyle = FlatStyle.Flat;
        }

        private void btnTutorial_MouseLeave(object sender, EventArgs e)
        {
            btnTutorial.ForeColor = Color.DarkCyan;
            btnTutorial.BackColor = Color.Transparent;
            btnTutorial.FlatStyle = FlatStyle.Flat;
        }
    }
}
