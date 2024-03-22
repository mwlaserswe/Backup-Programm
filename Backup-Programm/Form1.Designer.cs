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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new System.Windows.Forms.Button();
            txtTargetBaseDir = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripOpenOrder = new System.Windows.Forms.ToolStripMenuItem();
            toolStriDisplayOrder = new System.Windows.Forms.ToolStripMenuItem();
            toolStripEdtTast = new System.Windows.Forms.ToolStripMenuItem();
            btnStartBackup = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnTests = new System.Windows.Forms.Button();
            btnTest2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            chkSingleStep = new System.Windows.Forms.CheckBox();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            btnSelectSourcePath = new System.Windows.Forms.Button();
            btnSelectTargetPath = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lblFileCounter = new System.Windows.Forms.Label();
            Ablauftimer = new System.Windows.Forms.Timer(components);
            chkAutomatic = new System.Windows.Forms.CheckBox();
            lblCpuUsage = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblFilesChanged = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            chkDisplayAllFiles = new System.Windows.Forms.CheckBox();
            chkDisplayChangedFiles = new System.Windows.Forms.CheckBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            lblTime = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            DiplayTimer = new System.Windows.Forms.Timer(components);
            txtTime = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            btnSetTime = new System.Windows.Forms.Button();
            btnSkip = new System.Windows.Forms.Button();
            btnStopBackup = new System.Windows.Forms.Button();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(734, 53);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(139, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTargetBaseDir
            // 
            txtTargetBaseDir.Location = new System.Drawing.Point(39, 326);
            txtTargetBaseDir.Margin = new System.Windows.Forms.Padding(2);
            txtTargetBaseDir.Name = "txtTargetBaseDir";
            txtTargetBaseDir.Size = new System.Drawing.Size(873, 39);
            txtTargetBaseDir.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(39, 476);
            listBox1.Margin = new System.Windows.Forms.Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(953, 356);
            listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuFile });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1065, 40);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripOpenOrder, toolStriDisplayOrder, toolStripEdtTast });
            toolStripMenuFile.Name = "toolStripMenuFile";
            toolStripMenuFile.Size = new System.Drawing.Size(71, 36);
            toolStripMenuFile.Text = "File";
            // 
            // toolStripOpenOrder
            // 
            toolStripOpenOrder.Name = "toolStripOpenOrder";
            toolStripOpenOrder.Size = new System.Drawing.Size(417, 44);
            toolStripOpenOrder.Text = "Backup-Auftrag öffnen";
            toolStripOpenOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolStripOpenOrder.Click += toolStripOpenOrder_Click;
            // 
            // toolStriDisplayOrder
            // 
            toolStriDisplayOrder.Name = "toolStriDisplayOrder";
            toolStriDisplayOrder.Size = new System.Drawing.Size(417, 44);
            toolStriDisplayOrder.Text = "Backup-Auftrag anzeigen";
            toolStriDisplayOrder.Click += toolStriDisplayOrder_Click;
            // 
            // toolStripEdtTast
            // 
            toolStripEdtTast.Name = "toolStripEdtTast";
            toolStripEdtTast.Size = new System.Drawing.Size(417, 44);
            toolStripEdtTast.Text = "toolStripEditTast";
            toolStripEdtTast.Click += toolStripEdtTast_Click;
            // 
            // btnStartBackup
            // 
            btnStartBackup.Location = new System.Drawing.Point(46, 60);
            btnStartBackup.Margin = new System.Windows.Forms.Padding(2);
            btnStartBackup.Name = "btnStartBackup";
            btnStartBackup.Size = new System.Drawing.Size(266, 45);
            btnStartBackup.TabIndex = 4;
            btnStartBackup.Text = "Start Backup";
            btnStartBackup.UseVisualStyleBackColor = true;
            btnStartBackup.Click += btnGetOwnDir_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(858, 143);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(6, 6);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnTests
            // 
            btnTests.Location = new System.Drawing.Point(878, 77);
            btnTests.Margin = new System.Windows.Forms.Padding(2);
            btnTests.Name = "btnTests";
            btnTests.Size = new System.Drawing.Size(119, 41);
            btnTests.TabIndex = 8;
            btnTests.Text = "Write Cfg";
            btnTests.UseVisualStyleBackColor = true;
            btnTests.Click += btnTests_Click;
            // 
            // btnTest2
            // 
            btnTest2.Location = new System.Drawing.Point(878, 41);
            btnTest2.Margin = new System.Windows.Forms.Padding(2);
            btnTest2.Name = "btnTest2";
            btnTest2.Size = new System.Drawing.Size(113, 32);
            btnTest2.TabIndex = 9;
            btnTest2.Text = "Read Cfg";
            btnTest2.UseVisualStyleBackColor = true;
            btnTest2.Click += btnTest2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 292);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(377, 32);
            label2.TabIndex = 7;
            label2.Text = "Target-Verzeichnis für das Backup:";
            // 
            // chkSingleStep
            // 
            chkSingleStep.AutoSize = true;
            chkSingleStep.Location = new System.Drawing.Point(39, 380);
            chkSingleStep.Margin = new System.Windows.Forms.Padding(2);
            chkSingleStep.Name = "chkSingleStep";
            chkSingleStep.Size = new System.Drawing.Size(166, 36);
            chkSingleStep.TabIndex = 10;
            chkSingleStep.Text = "Single Step";
            chkSingleStep.UseVisualStyleBackColor = true;
            chkSingleStep.CheckedChanged += chkSingleStep_CheckedChanged;
            // 
            // btnSelectSourcePath
            // 
            btnSelectSourcePath.Location = new System.Drawing.Point(930, 245);
            btnSelectSourcePath.Margin = new System.Windows.Forms.Padding(2);
            btnSelectSourcePath.Name = "btnSelectSourcePath";
            btnSelectSourcePath.Size = new System.Drawing.Size(61, 36);
            btnSelectSourcePath.TabIndex = 11;
            btnSelectSourcePath.Text = ". . .";
            btnSelectSourcePath.UseVisualStyleBackColor = true;
            // 
            // btnSelectTargetPath
            // 
            btnSelectTargetPath.Location = new System.Drawing.Point(930, 326);
            btnSelectTargetPath.Margin = new System.Windows.Forms.Padding(2);
            btnSelectTargetPath.Name = "btnSelectTargetPath";
            btnSelectTargetPath.Size = new System.Drawing.Size(61, 36);
            btnSelectTargetPath.TabIndex = 11;
            btnSelectTargetPath.Text = ". . .";
            btnSelectTargetPath.UseVisualStyleBackColor = true;
            btnSelectTargetPath.Click += btnSelectTargetPath_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 416);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(258, 32);
            label3.TabIndex = 12;
            label3.Text = "No of files in directory:";
            // 
            // lblFileCounter
            // 
            lblFileCounter.AutoSize = true;
            lblFileCounter.Location = new System.Drawing.Point(286, 416);
            lblFileCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFileCounter.Name = "lblFileCounter";
            lblFileCounter.Size = new System.Drawing.Size(34, 32);
            lblFileCounter.TabIndex = 13;
            lblFileCounter.Text = "--";
            // 
            // Ablauftimer
            // 
            Ablauftimer.Interval = 10000;
            Ablauftimer.Tick += Ablauftimer_Tick;
            // 
            // chkAutomatic
            // 
            chkAutomatic.AutoSize = true;
            chkAutomatic.Location = new System.Drawing.Point(46, 113);
            chkAutomatic.Margin = new System.Windows.Forms.Padding(2);
            chkAutomatic.Name = "chkAutomatic";
            chkAutomatic.Size = new System.Drawing.Size(97, 36);
            chkAutomatic.TabIndex = 15;
            chkAutomatic.Text = "Auto";
            chkAutomatic.UseVisualStyleBackColor = true;
            chkAutomatic.CheckedChanged += chkAutomatic_CheckedChanged;
            // 
            // lblCpuUsage
            // 
            lblCpuUsage.AutoSize = true;
            lblCpuUsage.Location = new System.Drawing.Point(958, 416);
            lblCpuUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCpuUsage.Name = "lblCpuUsage";
            lblCpuUsage.Size = new System.Drawing.Size(34, 32);
            lblCpuUsage.TabIndex = 13;
            lblCpuUsage.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(817, 416);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 32);
            label5.TabIndex = 12;
            label5.Text = "CPU Usage:";
            // 
            // lblFilesChanged
            // 
            lblFilesChanged.AutoSize = true;
            lblFilesChanged.Location = new System.Drawing.Point(605, 416);
            lblFilesChanged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFilesChanged.Name = "lblFilesChanged";
            lblFilesChanged.Size = new System.Drawing.Size(34, 32);
            lblFilesChanged.TabIndex = 13;
            lblFilesChanged.Text = "--";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(384, 416);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(229, 32);
            label6.TabIndex = 12;
            label6.Text = "No of files changed:";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(450, 54);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(308, 49);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new System.Drawing.Size(121, 49);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkDisplayAllFiles
            // 
            chkDisplayAllFiles.AutoSize = true;
            chkDisplayAllFiles.Location = new System.Drawing.Point(370, 79);
            chkDisplayAllFiles.Margin = new System.Windows.Forms.Padding(2);
            chkDisplayAllFiles.Name = "chkDisplayAllFiles";
            chkDisplayAllFiles.Size = new System.Drawing.Size(198, 36);
            chkDisplayAllFiles.TabIndex = 17;
            chkDisplayAllFiles.Text = "Dispay all files";
            chkDisplayAllFiles.UseVisualStyleBackColor = true;
            chkDisplayAllFiles.CheckedChanged += chkDisplayAllFiles_CheckedChanged;
            // 
            // chkDisplayChangedFiles
            // 
            chkDisplayChangedFiles.AutoSize = true;
            chkDisplayChangedFiles.Location = new System.Drawing.Point(370, 119);
            chkDisplayChangedFiles.Margin = new System.Windows.Forms.Padding(2);
            chkDisplayChangedFiles.Name = "chkDisplayChangedFiles";
            chkDisplayChangedFiles.Size = new System.Drawing.Size(272, 36);
            chkDisplayChangedFiles.TabIndex = 18;
            chkDisplayChangedFiles.Text = "Display changed files";
            chkDisplayChangedFiles.UseVisualStyleBackColor = true;
            chkDisplayChangedFiles.CheckedChanged += chkDisplayChangedFiles_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(370, 160);
            checkBox4.Margin = new System.Windows.Forms.Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(159, 36);
            checkBox4.TabIndex = 18;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new System.Drawing.Point(832, 190);
            lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(34, 32);
            lblTime.TabIndex = 13;
            lblTime.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(540, 190);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(305, 32);
            label7.TabIndex = 12;
            label7.Text = "Zeit bis zum nächsten Lauf:";
            // 
            // DiplayTimer
            // 
            DiplayTimer.Enabled = true;
            DiplayTimer.Tick += DiplayTimer_Tick;
            // 
            // txtTime
            // 
            txtTime.Location = new System.Drawing.Point(819, 128);
            txtTime.Margin = new System.Windows.Forms.Padding(2);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(95, 39);
            txtTime.TabIndex = 1;
            txtTime.Text = "10";
            txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(659, 130);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(150, 32);
            label8.TabIndex = 7;
            label8.Text = "Wartezeit [s]:";
            // 
            // btnSetTime
            // 
            btnSetTime.Location = new System.Drawing.Point(932, 126);
            btnSetTime.Margin = new System.Windows.Forms.Padding(2);
            btnSetTime.Name = "btnSetTime";
            btnSetTime.Size = new System.Drawing.Size(59, 41);
            btnSetTime.TabIndex = 19;
            btnSetTime.Text = "OK";
            btnSetTime.UseVisualStyleBackColor = true;
            btnSetTime.Click += btnSetTime_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new System.Drawing.Point(919, 183);
            btnSkip.Margin = new System.Windows.Forms.Padding(2);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new System.Drawing.Size(72, 45);
            btnSkip.TabIndex = 20;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnStopBackup
            // 
            btnStopBackup.Location = new System.Drawing.Point(46, 162);
            btnStopBackup.Margin = new System.Windows.Forms.Padding(2);
            btnStopBackup.Name = "btnStopBackup";
            btnStopBackup.Size = new System.Drawing.Size(266, 45);
            btnStopBackup.TabIndex = 21;
            btnStopBackup.Text = "Stop Backup";
            btnStopBackup.UseVisualStyleBackColor = true;
            btnStopBackup.Click += btnStopBackup_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Backup-Programm";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1065, 867);
            Controls.Add(btnStopBackup);
            Controls.Add(btnSkip);
            Controls.Add(btnSetTime);
            Controls.Add(label8);
            Controls.Add(txtTime);
            Controls.Add(label7);
            Controls.Add(lblTime);
            Controls.Add(checkBox4);
            Controls.Add(chkDisplayChangedFiles);
            Controls.Add(chkDisplayAllFiles);
            Controls.Add(label6);
            Controls.Add(lblFilesChanged);
            Controls.Add(label5);
            Controls.Add(lblCpuUsage);
            Controls.Add(chkAutomatic);
            Controls.Add(lblFileCounter);
            Controls.Add(label3);
            Controls.Add(btnSelectTargetPath);
            Controls.Add(btnSelectSourcePath);
            Controls.Add(chkSingleStep);
            Controls.Add(label2);
            Controls.Add(btnTest2);
            Controls.Add(btnTests);
            Controls.Add(button2);
            Controls.Add(btnStartBackup);
            Controls.Add(listBox1);
            Controls.Add(txtTargetBaseDir);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTargetBaseDir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.CheckBox chkDisplayAllFiles;
        private System.Windows.Forms.CheckBox chkDisplayChangedFiles;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer DiplayTimer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.ToolStripMenuItem toolStriDisplayOrder;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnStopBackup;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

