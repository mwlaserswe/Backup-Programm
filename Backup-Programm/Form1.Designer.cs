namespace Backup_Programm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTargetBaseDir = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpenOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEdtTast = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceBaseDir = new System.Windows.Forms.TextBox();
            this.btnTests = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSingleStep = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectSourcePath = new System.Windows.Forms.Button();
            this.btnSelectTargetPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileCounter = new System.Windows.Forms.Label();
            this.Ablauftimer = new System.Windows.Forms.Timer(this.components);
            this.chkAutomatic = new System.Windows.Forms.CheckBox();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFilesChanged = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkAutostart = new System.Windows.Forms.CheckBox();
            this.chkDisplayAllFiles = new System.Windows.Forms.CheckBox();
            this.chkDisplayChangedFiles = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DiplayTimer = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTargetBaseDir
            // 
            this.txtTargetBaseDir.Location = new System.Drawing.Point(51, 419);
            this.txtTargetBaseDir.Name = "txtTargetBaseDir";
            this.txtTargetBaseDir.Size = new System.Drawing.Size(1140, 47);
            this.txtTargetBaseDir.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(51, 609);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1246, 455);
            this.listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 49);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpenOrder,
            this.toolStripEdtTast});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(87, 45);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripOpenOrder
            // 
            this.toolStripOpenOrder.Name = "toolStripOpenOrder";
            this.toolStripOpenOrder.Size = new System.Drawing.Size(484, 54);
            this.toolStripOpenOrder.Text = "Backup-Auftrag öffnen";
            this.toolStripOpenOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripOpenOrder.Click += new System.EventHandler(this.toolStripOpenOrder_Click);
            // 
            // toolStripEdtTast
            // 
            this.toolStripEdtTast.Name = "toolStripEdtTast";
            this.toolStripEdtTast.Size = new System.Drawing.Size(484, 54);
            this.toolStripEdtTast.Text = "toolStripEditTast";
            this.toolStripEdtTast.Click += new System.EventHandler(this.toolStripEdtTast_Click);
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(61, 77);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(348, 58);
            this.btnStartBackup.TabIndex = 4;
            this.btnStartBackup.Text = "Start Backup";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            this.btnStartBackup.Click += new System.EventHandler(this.btnGetOwnDir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1123, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Source-Verzeichnis für das Backup:";
            // 
            // txtSourceBaseDir
            // 
            this.txtSourceBaseDir.Location = new System.Drawing.Point(51, 314);
            this.txtSourceBaseDir.Name = "txtSourceBaseDir";
            this.txtSourceBaseDir.Size = new System.Drawing.Size(1142, 47);
            this.txtSourceBaseDir.TabIndex = 1;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(1148, 120);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(155, 51);
            this.btnTests.TabIndex = 8;
            this.btnTests.Text = "Write Cfg";
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(1148, 66);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(149, 41);
            this.btnTest2.TabIndex = 9;
            this.btnTest2.Text = "Read Cfg";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Target-Verzeichnis für das Backup:";
            // 
            // chkSingleStep
            // 
            this.chkSingleStep.AutoSize = true;
            this.chkSingleStep.Location = new System.Drawing.Point(51, 486);
            this.chkSingleStep.Name = "chkSingleStep";
            this.chkSingleStep.Size = new System.Drawing.Size(204, 45);
            this.chkSingleStep.TabIndex = 10;
            this.chkSingleStep.Text = "Single Step";
            this.chkSingleStep.UseVisualStyleBackColor = true;
            this.chkSingleStep.CheckedChanged += new System.EventHandler(this.chkSingleStep_CheckedChanged);
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.Location = new System.Drawing.Point(1217, 314);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(80, 47);
            this.btnSelectSourcePath.TabIndex = 11;
            this.btnSelectSourcePath.Text = ". . .";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            this.btnSelectSourcePath.Click += new System.EventHandler(this.btnSelectSourcePath_Click);
            // 
            // btnSelectTargetPath
            // 
            this.btnSelectTargetPath.Location = new System.Drawing.Point(1217, 419);
            this.btnSelectTargetPath.Name = "btnSelectTargetPath";
            this.btnSelectTargetPath.Size = new System.Drawing.Size(80, 47);
            this.btnSelectTargetPath.TabIndex = 11;
            this.btnSelectTargetPath.Text = ". . .";
            this.btnSelectTargetPath.UseVisualStyleBackColor = true;
            this.btnSelectTargetPath.Click += new System.EventHandler(this.btnSelectTargetPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "No of files in directory:";
            // 
            // lblFileCounter
            // 
            this.lblFileCounter.AutoSize = true;
            this.lblFileCounter.Location = new System.Drawing.Point(375, 534);
            this.lblFileCounter.Name = "lblFileCounter";
            this.lblFileCounter.Size = new System.Drawing.Size(42, 41);
            this.lblFileCounter.TabIndex = 13;
            this.lblFileCounter.Text = "--";
            // 
            // Ablauftimer
            // 
            this.Ablauftimer.Interval = 10000;
            this.Ablauftimer.Tick += new System.EventHandler(this.Ablauftimer_Tick);
            // 
            // chkAutomatic
            // 
            this.chkAutomatic.AutoSize = true;
            this.chkAutomatic.Location = new System.Drawing.Point(323, 486);
            this.chkAutomatic.Name = "chkAutomatic";
            this.chkAutomatic.Size = new System.Drawing.Size(341, 45);
            this.chkAutomatic.TabIndex = 15;
            this.chkAutomatic.Text = "Automatischer Ablauf";
            this.chkAutomatic.UseVisualStyleBackColor = true;
            this.chkAutomatic.CheckedChanged += new System.EventHandler(this.chkAutomatic_CheckedChanged);
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Location = new System.Drawing.Point(1254, 534);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(42, 41);
            this.lblCpuUsage.TabIndex = 13;
            this.lblCpuUsage.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1068, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPU Usage:";
            // 
            // lblFilesChanged
            // 
            this.lblFilesChanged.AutoSize = true;
            this.lblFilesChanged.Location = new System.Drawing.Point(791, 534);
            this.lblFilesChanged.Name = "lblFilesChanged";
            this.lblFilesChanged.Size = new System.Drawing.Size(42, 41);
            this.lblFilesChanged.TabIndex = 13;
            this.lblFilesChanged.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "No of files changed:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(450, 54);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(308, 49);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 49);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkAutostart
            // 
            this.chkAutostart.AutoSize = true;
            this.chkAutostart.Location = new System.Drawing.Point(484, 52);
            this.chkAutostart.Name = "chkAutostart";
            this.chkAutostart.Size = new System.Drawing.Size(178, 45);
            this.chkAutostart.TabIndex = 16;
            this.chkAutostart.Text = "Autostart";
            this.chkAutostart.UseVisualStyleBackColor = true;
            this.chkAutostart.CheckedChanged += new System.EventHandler(this.chkAutostart_CheckedChanged);
            // 
            // chkDisplayAllFiles
            // 
            this.chkDisplayAllFiles.AutoSize = true;
            this.chkDisplayAllFiles.Location = new System.Drawing.Point(484, 103);
            this.chkDisplayAllFiles.Name = "chkDisplayAllFiles";
            this.chkDisplayAllFiles.Size = new System.Drawing.Size(242, 45);
            this.chkDisplayAllFiles.TabIndex = 17;
            this.chkDisplayAllFiles.Text = "Dispay all files";
            this.chkDisplayAllFiles.UseVisualStyleBackColor = true;
            this.chkDisplayAllFiles.CheckedChanged += new System.EventHandler(this.chkDisplayAllFiles_CheckedChanged);
            // 
            // chkDisplayChangedFiles
            // 
            this.chkDisplayChangedFiles.AutoSize = true;
            this.chkDisplayChangedFiles.Location = new System.Drawing.Point(484, 154);
            this.chkDisplayChangedFiles.Name = "chkDisplayChangedFiles";
            this.chkDisplayChangedFiles.Size = new System.Drawing.Size(335, 45);
            this.chkDisplayChangedFiles.TabIndex = 18;
            this.chkDisplayChangedFiles.Text = "Display changed files";
            this.chkDisplayChangedFiles.UseVisualStyleBackColor = true;
            this.chkDisplayChangedFiles.CheckedChanged += new System.EventHandler(this.chkDisplayChangedFiles_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(484, 205);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(197, 45);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1096, 487);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 41);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zeit bis zum nächsten Lauf:";
            // 
            // DiplayTimer
            // 
            this.DiplayTimer.Enabled = true;
            this.DiplayTimer.Tick += new System.EventHandler(this.DiplayTimer_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(999, 203);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(194, 47);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "10";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(791, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wartezeit [s]:";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(1217, 201);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(79, 51);
            this.btnSetTime.TabIndex = 19;
            this.btnSetTime.Text = "OK";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1090);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.chkDisplayChangedFiles);
            this.Controls.Add(this.chkDisplayAllFiles);
            this.Controls.Add(this.chkAutostart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFilesChanged);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCpuUsage);
            this.Controls.Add(this.chkAutomatic);
            this.Controls.Add(this.lblFileCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectTargetPath);
            this.Controls.Add(this.btnSelectSourcePath);
            this.Controls.Add(this.chkSingleStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.txtSourceBaseDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTargetBaseDir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTargetBaseDir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceBaseDir;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSingleStep;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.Button btnSelectTargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileCounter;
        private System.Windows.Forms.Timer Ablauftimer;
        private System.Windows.Forms.CheckBox chkAutomatic;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFilesChanged;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenOrder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEdtTast;
        private System.Windows.Forms.CheckBox chkAutostart;
        private System.Windows.Forms.CheckBox chkDisplayAllFiles;
        private System.Windows.Forms.CheckBox chkDisplayChangedFiles;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer DiplayTimer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetTime;
    }
}

