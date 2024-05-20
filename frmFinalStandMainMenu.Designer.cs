namespace FinalStand_Version_1._0
{
    partial class frmFinalStandMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalStandMainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "..\\..\\resources\\sprites\\fire_sparks.gif";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(101, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnPlay.Location = new System.Drawing.Point(195, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(132, 48);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // btnControls
            // 
            this.btnControls.AutoSize = true;
            this.btnControls.BackColor = System.Drawing.Color.Transparent;
            this.btnControls.FlatAppearance.BorderSize = 0;
            this.btnControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnControls.Location = new System.Drawing.Point(177, 160);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(180, 48);
            this.btnControls.TabIndex = 2;
            this.btnControls.Text = "CONTROLS";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.MouseEnter += new System.EventHandler(this.btnControls_MouseEnter);
            this.btnControls.MouseLeave += new System.EventHandler(this.btnControls_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(138, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 45);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "\r\n█░░ ▄▀█ █▀ ▀█▀   █▀ ▀█▀ ▄▀█ █▄░█ █▀▄\r\n█▄▄ █▀█ ▄█ ░█░   ▄█ ░█░ █▀█ █░▀█ █▄▀";
            // 
            // frmFinalStandMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFinalStandMainMenu";
            this.Text = "Final Stand Main Menu";
            this.Load += new System.EventHandler(this.frmFinalStandMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Label lblTitle;
    }
}

