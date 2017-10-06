namespace miniSnesToolsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textFileName = new System.Windows.Forms.TextBox();
            this.cmdsfcFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.pictureBoxArt2 = new System.Windows.Forms.PictureBox();
            this.textImageFile = new System.Windows.Forms.TextBox();
            this.cmdImageFile = new System.Windows.Forms.Button();
            this.BoxArtGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSaveFeature = new System.Windows.Forms.CheckBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSimutanious = new System.Windows.Forms.CheckBox();
            this.radioPlayers2 = new System.Windows.Forms.RadioButton();
            this.radioPlayers1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGameName = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.cmdSelectOutputFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt2)).BeginInit();
            this.BoxArtGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(6, 19);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(190, 20);
            this.textFileName.TabIndex = 0;
            // 
            // cmdsfcFile
            // 
            this.cmdsfcFile.Location = new System.Drawing.Point(202, 19);
            this.cmdsfcFile.Name = "cmdsfcFile";
            this.cmdsfcFile.Size = new System.Drawing.Size(75, 23);
            this.cmdsfcFile.TabIndex = 1;
            this.cmdsfcFile.Text = "Select";
            this.cmdsfcFile.UseVisualStyleBackColor = true;
            this.cmdsfcFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLV-P-";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(46, 64);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(553, 286);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(84, 56);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxArt.Location = new System.Drawing.Point(6, 48);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(228, 160);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArt.TabIndex = 5;
            this.pictureBoxArt.TabStop = false;
            // 
            // pictureBoxArt2
            // 
            this.pictureBoxArt2.Location = new System.Drawing.Point(240, 108);
            this.pictureBoxArt2.Name = "pictureBoxArt2";
            this.pictureBoxArt2.Size = new System.Drawing.Size(40, 28);
            this.pictureBoxArt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArt2.TabIndex = 6;
            this.pictureBoxArt2.TabStop = false;
            this.pictureBoxArt2.Visible = false;
            // 
            // textImageFile
            // 
            this.textImageFile.AcceptsReturn = true;
            this.textImageFile.Location = new System.Drawing.Point(6, 19);
            this.textImageFile.Name = "textImageFile";
            this.textImageFile.Size = new System.Drawing.Size(193, 20);
            this.textImageFile.TabIndex = 7;
            this.textImageFile.TextChanged += new System.EventHandler(this.textImageFile_TextChanged);
            // 
            // cmdImageFile
            // 
            this.cmdImageFile.Location = new System.Drawing.Point(205, 19);
            this.cmdImageFile.Name = "cmdImageFile";
            this.cmdImageFile.Size = new System.Drawing.Size(75, 23);
            this.cmdImageFile.TabIndex = 8;
            this.cmdImageFile.Text = "Select";
            this.cmdImageFile.UseVisualStyleBackColor = true;
            this.cmdImageFile.Click += new System.EventHandler(this.cmdImageFile_Click);
            // 
            // BoxArtGroup
            // 
            this.BoxArtGroup.Controls.Add(this.textImageFile);
            this.BoxArtGroup.Controls.Add(this.cmdImageFile);
            this.BoxArtGroup.Controls.Add(this.pictureBoxArt2);
            this.BoxArtGroup.Controls.Add(this.pictureBoxArt);
            this.BoxArtGroup.Location = new System.Drawing.Point(337, 41);
            this.BoxArtGroup.Name = "BoxArtGroup";
            this.BoxArtGroup.Size = new System.Drawing.Size(302, 239);
            this.BoxArtGroup.TabIndex = 9;
            this.BoxArtGroup.TabStop = false;
            this.BoxArtGroup.Text = "Box Art";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Game I.D.";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSaveFeature);
            this.groupBox1.Controls.Add(this.txtReleaseDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkSimutanious);
            this.groupBox1.Controls.Add(this.radioPlayers2);
            this.groupBox1.Controls.Add(this.radioPlayers1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textGameName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdsfcFile);
            this.groupBox1.Controls.Add(this.textFileName);
            this.groupBox1.Location = new System.Drawing.Point(24, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 239);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rom Info.";
            // 
            // checkSaveFeature
            // 
            this.checkSaveFeature.AutoSize = true;
            this.checkSaveFeature.Location = new System.Drawing.Point(136, 66);
            this.checkSaveFeature.Name = "checkSaveFeature";
            this.checkSaveFeature.Size = new System.Drawing.Size(141, 17);
            this.checkSaveFeature.TabIndex = 22;
            this.checkSaveFeature.Text = "Game has Save Feature";
            this.checkSaveFeature.UseVisualStyleBackColor = true;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(147, 201);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseDate.TabIndex = 21;
            this.txtReleaseDate.Text = "1991-08-18";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Release Date:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(10, 201);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtPublisher.TabIndex = 19;
            this.txtPublisher.Text = "NINTENDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Publisher";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkSimutanious
            // 
            this.checkSimutanious.AutoSize = true;
            this.checkSimutanious.Location = new System.Drawing.Point(164, 157);
            this.checkSimutanious.Name = "checkSimutanious";
            this.checkSimutanious.Size = new System.Drawing.Size(83, 17);
            this.checkSimutanious.TabIndex = 17;
            this.checkSimutanious.Text = "Simutanious";
            this.checkSimutanious.UseVisualStyleBackColor = true;
            this.checkSimutanious.CheckedChanged += new System.EventHandler(this.checkSimutanious_CheckedChanged);
            // 
            // radioPlayers2
            // 
            this.radioPlayers2.AutoSize = true;
            this.radioPlayers2.Location = new System.Drawing.Point(79, 156);
            this.radioPlayers2.Name = "radioPlayers2";
            this.radioPlayers2.Size = new System.Drawing.Size(68, 17);
            this.radioPlayers2.TabIndex = 16;
            this.radioPlayers2.Text = "2 Players";
            this.radioPlayers2.UseVisualStyleBackColor = true;
            // 
            // radioPlayers1
            // 
            this.radioPlayers1.AutoSize = true;
            this.radioPlayers1.Checked = true;
            this.radioPlayers1.Location = new System.Drawing.Point(10, 156);
            this.radioPlayers1.Name = "radioPlayers1";
            this.radioPlayers1.Size = new System.Drawing.Size(63, 17);
            this.radioPlayers1.TabIndex = 15;
            this.radioPlayers1.TabStop = true;
            this.radioPlayers1.Text = "1 Player";
            this.radioPlayers1.UseVisualStyleBackColor = true;
            this.radioPlayers1.CheckedChanged += new System.EventHandler(this.radioPlayers1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. of Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Game Name";
            // 
            // textGameName
            // 
            this.textGameName.Location = new System.Drawing.Point(10, 108);
            this.textGameName.Name = "textGameName";
            this.textGameName.Size = new System.Drawing.Size(267, 20);
            this.textGameName.TabIndex = 12;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(117, 332);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(54, 13);
            this.lblLog.TabIndex = 13;
            this.lblLog.Text = "LOG FILE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "by: th3darkness";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Output Folder";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(110, 280);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(136, 20);
            this.txtOutputFolder.TabIndex = 24;
            // 
            // cmdSelectOutputFolder
            // 
            this.cmdSelectOutputFolder.Location = new System.Drawing.Point(256, 280);
            this.cmdSelectOutputFolder.Name = "cmdSelectOutputFolder";
            this.cmdSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectOutputFolder.TabIndex = 25;
            this.cmdSelectOutputFolder.Text = "Select";
            this.cmdSelectOutputFolder.UseVisualStyleBackColor = true;
            this.cmdSelectOutputFolder.Click += new System.EventHandler(this.cmdSelectOutputFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 354);
            this.Controls.Add(this.cmdSelectOutputFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxArtGroup);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZ miniSnes Rom Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt2)).EndInit();
            this.BoxArtGroup.ResumeLayout(false);
            this.BoxArtGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button cmdsfcFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.PictureBox pictureBoxArt2;
        private System.Windows.Forms.TextBox textImageFile;
        private System.Windows.Forms.Button cmdImageFile;
        private System.Windows.Forms.GroupBox BoxArtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGameName;
        private System.Windows.Forms.RadioButton radioPlayers2;
        private System.Windows.Forms.RadioButton radioPlayers1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkSimutanious;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.CheckBox checkSaveFeature;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button cmdSelectOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

