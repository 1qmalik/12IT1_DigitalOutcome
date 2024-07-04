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
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sniperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.grenadierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.mineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEFTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rIGHTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.healthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnemyHP = new System.Windows.Forms.Label();
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
            this.mnuMainBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopToolStripMenuItem,
            this.healthToolStripMenuItem,
            this.healthValueToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.scoreValueToolStripMenuItem,
            this.moneyStripMenuItem,
            this.startButtonToolStripMenuItem});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuMainBar.Size = new System.Drawing.Size(484, 26);
            this.mnuMainBar.TabIndex = 0;
            this.mnuMainBar.Text = "Menu Bar";
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infantryToolStripMenuItem,
            this.machineGunnerToolStripMenuItem,
            this.sniperToolStripMenuItem,
            this.grenadierToolStripMenuItem,
            this.mineToolStripMenuItem});
            this.shopToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.shopToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.shopToolStripMenuItem.Text = "|SHOP|";
            // 
            // infantryToolStripMenuItem
            // 
            this.infantryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPToolStripMenuItem,
            this.dOWNToolStripMenuItem,
            this.lEFTToolStripMenuItem,
            this.rIGHTToolStripMenuItem});
            this.infantryToolStripMenuItem.Name = "infantryToolStripMenuItem";
            this.infantryToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.infantryToolStripMenuItem.Text = "Infantry - $10 - 50 dmg";
            this.infantryToolStripMenuItem.Click += new System.EventHandler(this.infantryToolStripMenuItem_Click);
            // 
            // uPToolStripMenuItem
            // 
            this.uPToolStripMenuItem.Name = "uPToolStripMenuItem";
            this.uPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uPToolStripMenuItem.Text = "UP";
            this.uPToolStripMenuItem.Click += new System.EventHandler(this.uPToolStripMenuItem_Click);
            // 
            // dOWNToolStripMenuItem
            // 
            this.dOWNToolStripMenuItem.Name = "dOWNToolStripMenuItem";
            this.dOWNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dOWNToolStripMenuItem.Text = "DOWN";
            this.dOWNToolStripMenuItem.Click += new System.EventHandler(this.dOWNToolStripMenuItem_Click);
            // 
            // lEFTToolStripMenuItem
            // 
            this.lEFTToolStripMenuItem.Name = "lEFTToolStripMenuItem";
            this.lEFTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lEFTToolStripMenuItem.Text = "LEFT";
            this.lEFTToolStripMenuItem.Click += new System.EventHandler(this.lEFTToolStripMenuItem_Click);
            // 
            // rIGHTToolStripMenuItem
            // 
            this.rIGHTToolStripMenuItem.Name = "rIGHTToolStripMenuItem";
            this.rIGHTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.machineGunnerToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.machineGunnerToolStripMenuItem.Text = "Machine Gunner - $50 - 100 dmg";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "UP";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "DOWN";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "LEFT";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem4.Text = "RIGHT";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // sniperToolStripMenuItem
            // 
            this.sniperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.sniperToolStripMenuItem.Name = "sniperToolStripMenuItem";
            this.sniperToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.sniperToolStripMenuItem.Text = "Sniper - $250 - 150 dmg";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem5.Text = "UP";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem6.Text = "DOWN";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem7.Text = "LEFT";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem8.Text = "RIGHT";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // grenadierToolStripMenuItem
            // 
            this.grenadierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.grenadierToolStripMenuItem.Name = "grenadierToolStripMenuItem";
            this.grenadierToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.grenadierToolStripMenuItem.Text = "Grenadier - $500 - 200 dmg";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem9.Text = "UP";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem10.Text = "DOWN";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem11.Text = "LEFT";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem12.Text = "RIGHT";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // mineToolStripMenuItem
            // 
            this.mineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPToolStripMenuItem1,
            this.dOWToolStripMenuItem,
            this.lEFTToolStripMenuItem1,
            this.rIGHTToolStripMenuItem1});
            this.mineToolStripMenuItem.Name = "mineToolStripMenuItem";
            this.mineToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.mineToolStripMenuItem.Text = "Mine - $1000 - 500 dmg";
            // 
            // uPToolStripMenuItem1
            // 
            this.uPToolStripMenuItem1.Name = "uPToolStripMenuItem1";
            this.uPToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.uPToolStripMenuItem1.Text = "UP";
            this.uPToolStripMenuItem1.Click += new System.EventHandler(this.uPToolStripMenuItem1_Click);
            // 
            // dOWToolStripMenuItem
            // 
            this.dOWToolStripMenuItem.Name = "dOWToolStripMenuItem";
            this.dOWToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dOWToolStripMenuItem.Text = "DOWN";
            this.dOWToolStripMenuItem.Click += new System.EventHandler(this.dOWToolStripMenuItem_Click);
            // 
            // lEFTToolStripMenuItem1
            // 
            this.lEFTToolStripMenuItem1.Name = "lEFTToolStripMenuItem1";
            this.lEFTToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.lEFTToolStripMenuItem1.Text = "LEFT";
            this.lEFTToolStripMenuItem1.Click += new System.EventHandler(this.lEFTToolStripMenuItem1_Click);
            // 
            // rIGHTToolStripMenuItem1
            // 
            this.rIGHTToolStripMenuItem1.Name = "rIGHTToolStripMenuItem1";
            this.rIGHTToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.rIGHTToolStripMenuItem1.Text = "RIGHT";
            this.rIGHTToolStripMenuItem1.Click += new System.EventHandler(this.rIGHTToolStripMenuItem1_Click);
            // 
            // healthToolStripMenuItem
            // 
            this.healthToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.healthToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.healthToolStripMenuItem.Name = "healthToolStripMenuItem";
            this.healthToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.healthToolStripMenuItem.Text = "HEALTH:";
            // 
            // healthValueToolStripMenuItem
            // 
            this.healthValueToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.healthValueToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.healthValueToolStripMenuItem.Name = "healthValueToolStripMenuItem";
            this.healthValueToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.healthValueToolStripMenuItem.Text = "100";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.scoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.scoreToolStripMenuItem.Text = "SCORE:";
            // 
            // scoreValueToolStripMenuItem
            // 
            this.scoreValueToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.scoreValueToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.scoreValueToolStripMenuItem.Name = "scoreValueToolStripMenuItem";
            this.scoreValueToolStripMenuItem.Size = new System.Drawing.Size(36, 22);
            this.scoreValueToolStripMenuItem.Text = "scr";
            // 
            // moneyStripMenuItem
            // 
            this.moneyStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.moneyStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moneyStripMenuItem.Name = "moneyStripMenuItem";
            this.moneyStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.moneyStripMenuItem.Text = "MONEY:  ";
            // 
            // startButtonToolStripMenuItem
            // 
            this.startButtonToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.startButtonToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.startButtonToolStripMenuItem.Name = "startButtonToolStripMenuItem";
            this.startButtonToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.startButtonToolStripMenuItem.Text = "START-1";
            this.startButtonToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.Location = new System.Drawing.Point(342, 27);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(141, 18);
            this.lblEnemyHP.TabIndex = 1;
            this.lblEnemyHP.Text = "Enemy HP:";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMainBar;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infantryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOWNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rIGHTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineGunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sniperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grenadierToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem mineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEFTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rIGHTToolStripMenuItem1;
        private System.Windows.Forms.Label lblEnemyHP;
    }
}