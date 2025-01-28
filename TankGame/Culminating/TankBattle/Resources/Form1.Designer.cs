namespace TankBattle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise false.</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGameReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGameExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrPlanning = new System.Windows.Forms.Timer(this.components);
            this.lblP1Power = new System.Windows.Forms.Label();
            this.lblP1Angle = new System.Windows.Forms.Label();
            this.lblP2Power = new System.Windows.Forms.Label();
            this.lblP2Angle = new System.Windows.Forms.Label();
            this.lblCurrentStage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReady1 = new System.Windows.Forms.Label();
            this.lblReady2 = new System.Windows.Forms.Label();
            this.picGreenTankTop = new System.Windows.Forms.PictureBox();
            this.picGreenTankBottom = new System.Windows.Forms.PictureBox();
            this.picRedTankTop = new System.Windows.Forms.PictureBox();
            this.picRedTankBottom = new System.Windows.Forms.PictureBox();
            this.picWindCoverRight = new System.Windows.Forms.PictureBox();
            this.picWindCoverLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picP2Ready = new System.Windows.Forms.PictureBox();
            this.picP1Ready = new System.Windows.Forms.PictureBox();
            this.picP2Health = new System.Windows.Forms.PictureBox();
            this.picP1Health = new System.Windows.Forms.PictureBox();
            this.picWallHitBox = new System.Windows.Forms.PictureBox();
            this.picLowGround = new System.Windows.Forms.PictureBox();
            this.picHighGround = new System.Windows.Forms.PictureBox();
            this.picBullet = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenTankTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenTankBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTankTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTankBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindCoverRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindCoverLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Ready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Ready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWallHitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGameReset,
            this.toolStripMenuItem2,
            this.mnuGameExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // mnuGameReset
            // 
            this.mnuGameReset.Enabled = false;
            this.mnuGameReset.Name = "mnuGameReset";
            this.mnuGameReset.Size = new System.Drawing.Size(102, 22);
            this.mnuGameReset.Text = "Reset";
            this.mnuGameReset.Click += new System.EventHandler(this.mnuGameReset_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 6);
            // 
            // mnuGameExit
            // 
            this.mnuGameExit.Name = "mnuGameExit";
            this.mnuGameExit.Size = new System.Drawing.Size(102, 22);
            this.mnuGameExit.Text = "Exit";
            this.mnuGameExit.Click += new System.EventHandler(this.mnuGameExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(152, 22);
            this.mnuAboutHelp.Text = "Help";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);

            // 
            // tmrShoot
            // 
            this.tmrShoot.Interval = 10;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrPlanning
            // 
            this.tmrPlanning.Interval = 40;
            this.tmrPlanning.Tick += new System.EventHandler(this.tmrPlanning_Tick);
            // 
            // lblP1Power
            // 
            this.lblP1Power.AutoSize = true;
            this.lblP1Power.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblP1Power.ForeColor = System.Drawing.Color.White;
            this.lblP1Power.Location = new System.Drawing.Point(183, 664);
            this.lblP1Power.Name = "lblP1Power";
            this.lblP1Power.Size = new System.Drawing.Size(110, 24);
            this.lblP1Power.TabIndex = 9;
            this.lblP1Power.Text = "Power = 0%";
            this.lblP1Power.Visible = false;
            // 
            // lblP1Angle
            // 
            this.lblP1Angle.AutoSize = true;
            this.lblP1Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblP1Angle.ForeColor = System.Drawing.Color.White;
            this.lblP1Angle.Location = new System.Drawing.Point(183, 691);
            this.lblP1Angle.Name = "lblP1Angle";
            this.lblP1Angle.Size = new System.Drawing.Size(166, 24);
            this.lblP1Angle.TabIndex = 10;
            this.lblP1Angle.Text = "Angle = 0 degrees";
            this.lblP1Angle.Visible = false;
            // 
            // lblP2Power
            // 
            this.lblP2Power.AutoSize = true;
            this.lblP2Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblP2Power.ForeColor = System.Drawing.Color.White;
            this.lblP2Power.Location = new System.Drawing.Point(845, 765);
            this.lblP2Power.Name = "lblP2Power";
            this.lblP2Power.Size = new System.Drawing.Size(110, 24);
            this.lblP2Power.TabIndex = 11;
            this.lblP2Power.Text = "Power = 0%";
            this.lblP2Power.Visible = false;
            // 
            // lblP2Angle
            // 
            this.lblP2Angle.AutoSize = true;
            this.lblP2Angle.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblP2Angle.ForeColor = System.Drawing.Color.White;
            this.lblP2Angle.Location = new System.Drawing.Point(845, 792);
            this.lblP2Angle.Name = "lblP2Angle";
            this.lblP2Angle.Size = new System.Drawing.Size(166, 24);
            this.lblP2Angle.TabIndex = 12;
            this.lblP2Angle.Text = "Angle = 0 degrees";
            this.lblP2Angle.Visible = false;
            // 
            // lblCurrentStage
            // 
            this.lblCurrentStage.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Italic);
            this.lblCurrentStage.ForeColor = System.Drawing.Color.White;
            this.lblCurrentStage.Location = new System.Drawing.Point(404, 107);
            this.lblCurrentStage.Name = "lblCurrentStage";
            this.lblCurrentStage.Size = new System.Drawing.Size(391, 102);
            this.lblCurrentStage.TabIndex = 15;
            this.lblCurrentStage.Text = "Press Enter to Start";
            this.lblCurrentStage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(496, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Current Wind:";
            // 
            // lblReady1
            // 
            this.lblReady1.AutoSize = true;
            this.lblReady1.Font = new System.Drawing.Font("OCR A Extended", 26.25F);
            this.lblReady1.ForeColor = System.Drawing.Color.White;
            this.lblReady1.Location = new System.Drawing.Point(181, 301);
            this.lblReady1.Name = "lblReady1";
            this.lblReady1.Size = new System.Drawing.Size(143, 37);
            this.lblReady1.TabIndex = 23;
            this.lblReady1.Text = "Ready?";
            this.lblReady1.Visible = false;
            // 
            // lblReady2
            // 
            this.lblReady2.AutoSize = true;
            this.lblReady2.Font = new System.Drawing.Font("OCR A Extended", 26.25F);
            this.lblReady2.ForeColor = System.Drawing.Color.White;
            this.lblReady2.Location = new System.Drawing.Point(861, 301);
            this.lblReady2.Name = "lblReady2";
            this.lblReady2.Size = new System.Drawing.Size(143, 37);
            this.lblReady2.TabIndex = 24;
            this.lblReady2.Text = "Ready?";
            this.lblReady2.Visible = false;
            // 
            // picGreenTankTop
            // 
            this.picGreenTankTop.Image = global::TankBattle.Resource1.GreenTankTop;
            this.picGreenTankTop.Location = new System.Drawing.Point(883, 729);
            this.picGreenTankTop.Name = "picGreenTankTop";
            this.picGreenTankTop.Size = new System.Drawing.Size(20, 9);
            this.picGreenTankTop.TabIndex = 32;
            this.picGreenTankTop.TabStop = false;
            // 
            // picGreenTankBottom
            // 
            this.picGreenTankBottom.Image = global::TankBattle.Resource1.GreenTankBottom;
            this.picGreenTankBottom.Location = new System.Drawing.Point(868, 737);
            this.picGreenTankBottom.Name = "picGreenTankBottom";
            this.picGreenTankBottom.Size = new System.Drawing.Size(44, 13);
            this.picGreenTankBottom.TabIndex = 31;
            this.picGreenTankBottom.TabStop = false;
            // 
            // picRedTankTop
            // 
            this.picRedTankTop.Image = global::TankBattle.Resource1.RedTankTop;
            this.picRedTankTop.Location = new System.Drawing.Point(220, 628);
            this.picRedTankTop.Name = "picRedTankTop";
            this.picRedTankTop.Size = new System.Drawing.Size(20, 9);
            this.picRedTankTop.TabIndex = 30;
            this.picRedTankTop.TabStop = false;
            // 
            // picRedTankBottom
            // 
            this.picRedTankBottom.Image = global::TankBattle.Resource1.RedTankBottom;
            this.picRedTankBottom.Location = new System.Drawing.Point(212, 637);
            this.picRedTankBottom.Name = "picRedTankBottom";
            this.picRedTankBottom.Size = new System.Drawing.Size(44, 13);
            this.picRedTankBottom.TabIndex = 29;
            this.picRedTankBottom.TabStop = false;
            // 
            // picWindCoverRight
            // 
            this.picWindCoverRight.Location = new System.Drawing.Point(595, 54);
            this.picWindCoverRight.Name = "picWindCoverRight";
            this.picWindCoverRight.Size = new System.Drawing.Size(125, 31);
            this.picWindCoverRight.TabIndex = 28;
            this.picWindCoverRight.TabStop = false;
            // 
            // picWindCoverLeft
            // 
            this.picWindCoverLeft.Location = new System.Drawing.Point(468, 54);
            this.picWindCoverLeft.Name = "picWindCoverLeft";
            this.picWindCoverLeft.Size = new System.Drawing.Size(125, 31);
            this.picWindCoverLeft.TabIndex = 27;
            this.picWindCoverLeft.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TankBattle.Resource1.Tower;
            this.pictureBox4.Location = new System.Drawing.Point(526, 406);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 244);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TankBattle.Resource1.Character1;
            this.pictureBox3.Location = new System.Drawing.Point(1015, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 119);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TankBattle.Resource1.Character2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 119);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TankBattle.Resource1.WindArrowsToCover;
            this.pictureBox1.Location = new System.Drawing.Point(444, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 35);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // picP2Ready
            // 
            this.picP2Ready.BackColor = System.Drawing.Color.Transparent;
            this.picP2Ready.Image = global::TankBattle.Resource1.EmptyCheck;
            this.picP2Ready.Location = new System.Drawing.Point(1015, 228);
            this.picP2Ready.Name = "picP2Ready";
            this.picP2Ready.Size = new System.Drawing.Size(157, 157);
            this.picP2Ready.TabIndex = 14;
            this.picP2Ready.TabStop = false;
            this.picP2Ready.Visible = false;
            // 
            // picP1Ready
            // 
            this.picP1Ready.BackColor = System.Drawing.Color.Transparent;
            this.picP1Ready.Image = global::TankBattle.Resource1.EmptyCheck;
            this.picP1Ready.Location = new System.Drawing.Point(14, 228);
            this.picP1Ready.Name = "picP1Ready";
            this.picP1Ready.Size = new System.Drawing.Size(157, 157);
            this.picP1Ready.TabIndex = 13;
            this.picP1Ready.TabStop = false;
            this.picP1Ready.Visible = false;
            // 
            // picP2Health
            // 
            this.picP2Health.BackColor = System.Drawing.Color.Transparent;
            this.picP2Health.Image = global::TankBattle.Resource1.GreenHealth;
            this.picP2Health.Location = new System.Drawing.Point(1015, 177);
            this.picP2Health.Name = "picP2Health";
            this.picP2Health.Size = new System.Drawing.Size(156, 32);
            this.picP2Health.TabIndex = 8;
            this.picP2Health.TabStop = false;
            // 
            // picP1Health
            // 
            this.picP1Health.BackColor = System.Drawing.Color.Transparent;
            this.picP1Health.Image = global::TankBattle.Resource1.RedHealth;
            this.picP1Health.Location = new System.Drawing.Point(14, 177);
            this.picP1Health.Name = "picP1Health";
            this.picP1Health.Size = new System.Drawing.Size(156, 32);
            this.picP1Health.TabIndex = 7;
            this.picP1Health.TabStop = false;
            // 
            // picWallHitBox
            // 
            this.picWallHitBox.BackColor = System.Drawing.Color.DimGray;
            this.picWallHitBox.Location = new System.Drawing.Point(535, 417);
            this.picWallHitBox.Name = "picWallHitBox";
            this.picWallHitBox.Size = new System.Drawing.Size(110, 233);
            this.picWallHitBox.TabIndex = 4;
            this.picWallHitBox.TabStop = false;
            // 
            // picLowGround
            // 
            this.picLowGround.BackColor = System.Drawing.Color.SaddleBrown;
            this.picLowGround.Image = global::TankBattle.Resource1.LowGround;
            this.picLowGround.Location = new System.Drawing.Point(645, 750);
            this.picLowGround.Name = "picLowGround";
            this.picLowGround.Size = new System.Drawing.Size(540, 166);
            this.picLowGround.TabIndex = 3;
            this.picLowGround.TabStop = false;
            // 
            // picHighGround
            // 
            this.picHighGround.BackColor = System.Drawing.Color.SaddleBrown;
            this.picHighGround.Image = global::TankBattle.Resource1.HighGround;
            this.picHighGround.Location = new System.Drawing.Point(0, 650);
            this.picHighGround.Name = "picHighGround";
            this.picHighGround.Size = new System.Drawing.Size(645, 266);
            this.picHighGround.TabIndex = 2;
            this.picHighGround.TabStop = false;
            // 
            // picBullet
            // 
            this.picBullet.BackColor = System.Drawing.Color.White;
            this.picBullet.Location = new System.Drawing.Point(52, 578);
            this.picBullet.Name = "picBullet";
            this.picBullet.Size = new System.Drawing.Size(5, 5);
            this.picBullet.TabIndex = 0;
            this.picBullet.TabStop = false;
            this.picBullet.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::TankBattle.Resource1.GreenHealthEmpty;
            this.pictureBox5.Location = new System.Drawing.Point(1015, 177);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(156, 32);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::TankBattle.Resource1.RedHealthEmpty;
            this.pictureBox6.Location = new System.Drawing.Point(14, 177);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(156, 32);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.picGreenTankTop);
            this.Controls.Add(this.picGreenTankBottom);
            this.Controls.Add(this.picRedTankTop);
            this.Controls.Add(this.picRedTankBottom);
            this.Controls.Add(this.picWindCoverRight);
            this.Controls.Add(this.picWindCoverLeft);
            this.Controls.Add(this.lblReady2);
            this.Controls.Add(this.lblReady1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentStage);
            this.Controls.Add(this.picP2Ready);
            this.Controls.Add(this.picP1Ready);
            this.Controls.Add(this.lblP2Angle);
            this.Controls.Add(this.lblP2Power);
            this.Controls.Add(this.lblP1Angle);
            this.Controls.Add(this.lblP1Power);
            this.Controls.Add(this.picP2Health);
            this.Controls.Add(this.picP1Health);
            this.Controls.Add(this.picWallHitBox);
            this.Controls.Add(this.picLowGround);
            this.Controls.Add(this.picHighGround);
            this.Controls.Add(this.picBullet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank Battle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenTankTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenTankBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTankTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedTankBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindCoverRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindCoverLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Ready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Ready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWallHitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBullet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGameReset;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.PictureBox picHighGround;
        private System.Windows.Forms.PictureBox picLowGround;
        private System.Windows.Forms.PictureBox picWallHitBox;
        private System.Windows.Forms.Timer tmrPlanning;
        private System.Windows.Forms.PictureBox picP1Health;
        private System.Windows.Forms.PictureBox picP2Health;
        private System.Windows.Forms.Label lblP1Power;
        private System.Windows.Forms.Label lblP1Angle;
        private System.Windows.Forms.Label lblP2Power;
        private System.Windows.Forms.Label lblP2Angle;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.PictureBox picP1Ready;
        private System.Windows.Forms.PictureBox picP2Ready;
        private System.Windows.Forms.Label lblCurrentStage;
        private System.Windows.Forms.ToolStripMenuItem mnuGameExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblReady1;
        private System.Windows.Forms.Label lblReady2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picWindCoverLeft;
        private System.Windows.Forms.PictureBox picWindCoverRight;
        private System.Windows.Forms.PictureBox picRedTankBottom;
        private System.Windows.Forms.PictureBox picRedTankTop;
        private System.Windows.Forms.PictureBox picGreenTankBottom;
        private System.Windows.Forms.PictureBox picGreenTankTop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

