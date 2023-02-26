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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTargetBaseDir = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSelectSourcePath = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetAppDir = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTargetBaseDir
            // 
            this.txtTargetBaseDir.Location = new System.Drawing.Point(51, 345);
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
            this.toolStripSelectSourcePath});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(87, 45);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripSelectSourcePath
            // 
            this.toolStripSelectSourcePath.Name = "toolStripSelectSourcePath";
            this.toolStripSelectSourcePath.Size = new System.Drawing.Size(428, 54);
            this.toolStripSelectSourcePath.Text = "Select Source Path";
            // 
            // btnGetAppDir
            // 
            this.btnGetAppDir.Location = new System.Drawing.Point(396, 66);
            this.btnGetAppDir.Name = "btnGetAppDir";
            this.btnGetAppDir.Size = new System.Drawing.Size(348, 58);
            this.btnGetAppDir.TabIndex = 4;
            this.btnGetAppDir.Text = "Start Backup";
            this.btnGetAppDir.UseVisualStyleBackColor = true;
            this.btnGetAppDir.Click += new System.EventHandler(this.btnGetOwnDir_Click);
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
            this.label1.Location = new System.Drawing.Point(51, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Source-Verzeichnis für das Backup:";
            // 
            // txtSourceBaseDir
            // 
            this.txtSourceBaseDir.Location = new System.Drawing.Point(51, 238);
            this.txtSourceBaseDir.Name = "txtSourceBaseDir";
            this.txtSourceBaseDir.Size = new System.Drawing.Size(1142, 47);
            this.txtSourceBaseDir.TabIndex = 1;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(809, 66);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(179, 70);
            this.btnTests.TabIndex = 8;
            this.btnTests.Text = "Write Cfg";
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(1031, 67);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(160, 68);
            this.btnTest2.TabIndex = 9;
            this.btnTest2.Text = "Read Cfg";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Target-Verzeichnis für das Backup:";
            // 
            // chkSingleStep
            // 
            this.chkSingleStep.AutoSize = true;
            this.chkSingleStep.Location = new System.Drawing.Point(51, 438);
            this.chkSingleStep.Name = "chkSingleStep";
            this.chkSingleStep.Size = new System.Drawing.Size(204, 45);
            this.chkSingleStep.TabIndex = 10;
            this.chkSingleStep.Text = "Single Step";
            this.chkSingleStep.UseVisualStyleBackColor = true;
            this.chkSingleStep.CheckedChanged += new System.EventHandler(this.chkSingleStep_CheckedChanged);
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.Location = new System.Drawing.Point(1217, 238);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(80, 47);
            this.btnSelectSourcePath.TabIndex = 11;
            this.btnSelectSourcePath.Text = ". . .";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            this.btnSelectSourcePath.Click += new System.EventHandler(this.btnSelectSourcePath_Click);
            // 
            // btnSelectTargetPath
            // 
            this.btnSelectTargetPath.Location = new System.Drawing.Point(1217, 345);
            this.btnSelectTargetPath.Name = "btnSelectTargetPath";
            this.btnSelectTargetPath.Size = new System.Drawing.Size(80, 47);
            this.btnSelectTargetPath.TabIndex = 11;
            this.btnSelectTargetPath.Text = ". . .";
            this.btnSelectTargetPath.UseVisualStyleBackColor = true;
            this.btnSelectTargetPath.Click += new System.EventHandler(this.btnSelectTargetPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1090);
            this.Controls.Add(this.btnSelectTargetPath);
            this.Controls.Add(this.btnSelectSourcePath);
            this.Controls.Add(this.chkSingleStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.txtSourceBaseDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGetAppDir);
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
        private System.Windows.Forms.Button btnGetAppDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceBaseDir;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSingleStep;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSelectSourcePath;
        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.Button btnSelectTargetPath;
    }
}

