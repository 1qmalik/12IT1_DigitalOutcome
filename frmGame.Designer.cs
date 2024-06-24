namespace FinalStand
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrGameLoop = new System.Windows.Forms.Timer(this.components);
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.sHOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infantryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOWNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rIGHTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineGunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.grenadier200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.grenadier250ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.mine1000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.hEALTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrGameLoop
            // 
            this.tmrGameLoop.Enabled = true;
            this.tmrGameLoop.Interval = 1;
            this.tmrGameLoop.Tick += new System.EventHandler(this.tmrGameLoop_Tick);
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHOPToolStripMenuItem,
            this.hEALTHToolStripMenuItem,
            this.sCOREToolStripMenuItem,
            this.sCOREToolStripMenuItem1,
            this.scrToolStripMenuItem,
            this.toolStripMenuItem17});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(484, 30);
            this.mnuMainBar.TabIndex = 0;
            this.mnuMainBar.Text = "Menu Bar";
            // 
            // sHOPToolStripMenuItem
            // 
            this.sHOPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infantryToolStripMenuItem,
            this.machineGunnerToolStripMenuItem,
            this.grenadier200ToolStripMenuItem,
            this.grenadier250ToolStripMenuItem,
            this.mine1000ToolStripMenuItem});
            this.sHOPToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sHOPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOPToolStripMenuItem.Name = "sHOPToolStripMenuItem";
            this.sHOPToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.sHOPToolStripMenuItem.Text = "|SHOP|";
            // 
            // infantryToolStripMenuItem
            // 
            this.infantryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPToolStripMenuItem,
            this.dOWNToolStripMenuItem,
            this.lEFTToolStripMenuItem,
            this.rIGHTToolStripMenuItem});
            this.infantryToolStripMenuItem.Name = "infantryToolStripMenuItem";
            this.infantryToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.infantryToolStripMenuItem.Text = "Infantry - $10";
            // 
            // uPToolStripMenuItem
            // 
            this.uPToolStripMenuItem.Name = "uPToolStripMenuItem";
            this.uPToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.uPToolStripMenuItem.Text = "UP";
            this.uPToolStripMenuItem.Click += new System.EventHandler(this.uPToolStripMenuItem_Click);
            // 
            // dOWNToolStripMenuItem
            // 
            this.dOWNToolStripMenuItem.Name = "dOWNToolStripMenuItem";
            this.dOWNToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.dOWNToolStripMenuItem.Text = "DOWN";
            this.dOWNToolStripMenuItem.Click += new System.EventHandler(this.dOWNToolStripMenuItem_Click);
            // 
            // lEFTToolStripMenuItem
            // 
            this.lEFTToolStripMenuItem.Name = "lEFTToolStripMenuItem";
            this.lEFTToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lEFTToolStripMenuItem.Text = "LEFT";
            this.lEFTToolStripMenuItem.Click += new System.EventHandler(this.lEFTToolStripMenuItem_Click);
            // 
            // rIGHTToolStripMenuItem
            // 
            this.rIGHTToolStripMenuItem.Name = "rIGHTToolStripMenuItem";
            this.rIGHTToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rIGHTToolStripMenuItem.Text = "RIGHT";
            this.rIGHTToolStripMenuItem.Click += new System.EventHandler(this.rIGHTToolStripMenuItem_Click);
            // 
            // machineGunnerToolStripMenuItem
            // 
            this.machineGunnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.machineGunnerToolStripMenuItem.Name = "machineGunnerToolStripMenuItem";
            this.machineGunnerToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.machineGunnerToolStripMenuItem.Text = "Machine Gunner - $50";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem1.Text = "UP";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem2.Text = "DOWN";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem3.Text = "LEFT";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem4.Text = "RIGHT";
            // 
            // grenadier200ToolStripMenuItem
            // 
            this.grenadier200ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.grenadier200ToolStripMenuItem.Name = "grenadier200ToolStripMenuItem";
            this.grenadier200ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.grenadier200ToolStripMenuItem.Text = "Sniper - $100";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem5.Text = "UP";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem6.Text = "DOWN";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem7.Text = "LEFT";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem8.Text = "RIGHT";
            // 
            // grenadier250ToolStripMenuItem
            // 
            this.grenadier250ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.grenadier250ToolStripMenuItem.Name = "grenadier250ToolStripMenuItem";
            this.grenadier250ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.grenadier250ToolStripMenuItem.Text = "Grenadier - $250";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem9.Text = "UP";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem10.Text = "DOWN";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem11.Text = "LEFT";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem12.Text = "RIGHT";
            // 
            // mine1000ToolStripMenuItem
            // 
            this.mine1000ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.mine1000ToolStripMenuItem.Name = "mine1000ToolStripMenuItem";
            this.mine1000ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.mine1000ToolStripMenuItem.Text = "Mine -$1000";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem13.Text = "UP";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem14.Text = "DOWN";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem15.Text = "LEFT";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem16.Text = "RIGHT";
            // 
            // hEALTHToolStripMenuItem
            // 
            this.hEALTHToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.hEALTHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hEALTHToolStripMenuItem.Name = "hEALTHToolStripMenuItem";
            this.hEALTHToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.hEALTHToolStripMenuItem.Text = "HEALTH:";
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.sCOREToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.sCOREToolStripMenuItem.Text = "100";
            // 
            // sCOREToolStripMenuItem1
            // 
            this.sCOREToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.sCOREToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.sCOREToolStripMenuItem1.Name = "sCOREToolStripMenuItem1";
            this.sCOREToolStripMenuItem1.Size = new System.Drawing.Size(76, 26);
            this.sCOREToolStripMenuItem1.Text = "SCORE:";
            // 
            // scrToolStripMenuItem
            // 
            this.scrToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.scrToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.scrToolStripMenuItem.Name = "scrToolStripMenuItem";
            this.scrToolStripMenuItem.Size = new System.Drawing.Size(45, 26);
            this.scrToolStripMenuItem.Text = "scr";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(90, 26);
            this.toolStripMenuItem17.Text = "MONEY:  ";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseMove);
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrGameLoop;
        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem sHOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infantryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOWNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rIGHTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineGunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grenadier200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grenadier250ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem mine1000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem hEALTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
    }
}