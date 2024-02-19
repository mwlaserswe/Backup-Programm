

// Menu             https://www.c-sharpcorner.com/uploadfile/mahesh/menustrip-in-C-Sharp/
// WalkDirectory    https://learn.microsoft.com/de-DE/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree
// Dir der Anw.     https://dotnet-snippets.de/snippet/das-verzeichnis-der-anwendung-ermitteln/23?utm_content=cmp-true
// File Copy        https://dotnet-snippets.de/snippet/dateilisten-kopieren/1315

//  Backup: z.B. von D:\Eigene Dateien\Test\Text Folder 1      --->   D:\Test Backup Server\Test\Text Folder 1
//  BasisDirSource: D:\Eigene Dateien\
//  BasisDirBackup: D:\Test Backup Server\
//  Swcud7ZgG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;
using System.Diagnostics;

using System.Xml.Serialization;

namespace Backup_Programm
{

    public partial class Form1 : Form
    {

        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        static PerformanceCounter cpuCounter; // globaler PerformanceCounter 

        string BasisDirSource = @"C:\Temp\";
        string BasisDirTarget = @"D:\Temp\";
        int DisplaySeconds = 0;
        bool SingleStep = false;
        bool AutoLoop = false;
        bool AutoStart = false;
        bool FlagListAllFiles = false;
        bool FlagListChangedFiles = false;
        int WaitingTime = 10;


        int FileCounter = 0;
        int FilesChanged = 0;
        //string BackupTask = @"D:\BackupCfg.xml";

        int CntMeanValue = 0;
        float CpuUsage = 0;

        //BackupConfig CfgFile = new BackupConfig();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Read configuration
            Globals.CfgFile = (BackupConfig)MWTools.Tools.DeserializeFromXmlFile(Globals.BackupTask, Globals.CfgFile.GetType(), Encoding.Default);

            if (Globals.CfgFile != null)
            {
                BasisDirSource = Globals.CfgFile.BasisDirSource;
                BasisDirTarget = Globals.CfgFile.BasisDirTarget;

                txtSourceBaseDir.Text = BasisDirSource;
                txtTargetBaseDir.Text = BasisDirTarget;

                WaitingTime = Globals.CfgFile.WaitingTime;
                if (WaitingTime == 0)
                {
                    WaitingTime = 10;
                    Globals.CfgFile.WaitingTime = WaitingTime;
                    MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
                }
                txtTime.Text = WaitingTime.ToString();
                Ablauftimer.Interval = WaitingTime * 1000;

                SingleStep = Globals.CfgFile.SingleStep;
                chkSingleStep.Checked = SingleStep;

                AutoStart = Globals.CfgFile.Flags.FlagAutoStart;
                chkAutostart.Checked = AutoStart;

                FlagListAllFiles = Globals.CfgFile.Flags.FlagDisplayAllFiles;
                chkDisplayAllFiles.Checked = FlagListAllFiles;

                FlagListChangedFiles = Globals.CfgFile.Flags.FlagDisplayChangedFiles;
                chkDisplayChangedFiles.Checked = FlagListChangedFiles;

                AutoLoop = Globals.CfgFile.Flags.FlagAutoLoop;
                chkAutomatic.Checked = FlagListAllFiles;

                if (AutoStart)
                {
                    AutoLoop = true;
                    chkAutomatic.Checked = AutoLoop;
                }

                btnStartBackup.Enabled = true;
                this.Text = Globals.BackupTask;
            }
            else
                btnStartBackup.Enabled = false;
            this.Text = Globals.BackupTask;

            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total"; // "_Total" entspricht der gesamten CPU Auslastung, Bei Computern mit mehr als 1 logischem Prozessor: "0" dem ersten Core, "1" dem zweiten...
        }

        private void chkSingleStep_CheckedChanged(object sender, EventArgs e)
        {
            SingleStep = chkSingleStep.Checked;
            Globals.CfgFile.SingleStep = SingleStep;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);

        }
        private void btnSelectSourcePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = BasisDirSource;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BasisDirSource = folderBrowserDialog1.SelectedPath;
                Globals.CfgFile.BasisDirSource = BasisDirSource;
                MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
                txtSourceBaseDir.Text = BasisDirSource;
            }
        }

        private void btnSelectTargetPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = BasisDirTarget;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BasisDirTarget = folderBrowserDialog1.SelectedPath;
                Globals.CfgFile.BasisDirTarget = BasisDirTarget;
                MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
                txtTargetBaseDir.Text = BasisDirTarget;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Globals Glb = new Globals();

            Globals.myInt = 10;

            int a = 1;

        }
        private void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            Application.DoEvents();

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, you
                // can try to elevate your privileges and access the file again.
                log.Add(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                // Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo SourceFile in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().

                    // Console.WriteLine(fi.FullName);

                    if (FlagListAllFiles)
                    {
                        listBox1.Items.Add(SourceFile.FullName);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.Update();
                    }

                    String TargetFileFullPath = GenerateFileNames(SourceFile.FullName, BasisDirSource, BasisDirTarget);

                    //FileInfo SourceFile = new FileInfo(SourceFillFullPath);
                    FileInfo TargetFile = new FileInfo(TargetFileFullPath);

                    FileCounter++;
                    lblFileCounter.Text = FileCounter.ToString();
                    lblFileCounter.Update();
                    CopyFile(SourceFile, TargetFile);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo);
                }
            }
        }


        private void btnGetOwnDir_Click(object sender, EventArgs e)
        {
            btnStartBackup.Text = "...Running...";
            btnStartBackup.Update();

            FilesChanged = 0;
            lblFilesChanged.Text = FilesChanged.ToString();
            lblFilesChanged.Update();


            //====================================================================
            Ablauf();
            //====================================================================

            btnStartBackup.Text = "Start Backup";
            btnStartBackup.Update();
        }




        private void Ablauf()
        {
            // Configuration erneut einlesen, damit man die Liste während des Programmlaufs ändern kann
            Globals.CfgFile = (BackupConfig)MWTools.Tools.DeserializeFromXmlFile(Globals.BackupTask, Globals.CfgFile.GetType(), Encoding.Default);

            FileInfo BackupList = new FileInfo(Assembly.GetEntryAssembly().Location);

            int counter = 0;
            listBox1.Items.Clear();
            //listBox1.Items.Add("====>     Backup-Liste wird von vorne abgearbeitet");

            // Read the Backup listc ine by line.  
            foreach (string line in Globals.CfgFile.BackupList)
            {
                if (line != "")


                {
                    if (counter >= Globals.CfgFile.CurrentEntry)
                    {
                        listBox1.Items.Add("====>    " + line);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;

                        FileCounter = 0;
                        DirectoryInfo BackupListEntry = new DirectoryInfo(line);

                        int pos = line.IndexOf(BasisDirSource, 0);
                        if (pos < 0)
                        {
                            string title = "Backup Programm";
                            string message = "Das Source-Directory" + Environment.NewLine
                                + BasisDirSource + Environment.NewLine
                                + "passt nicht zum Directory" + Environment.NewLine
                                + line;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.OK)
                            {
                                break;

                                this.Close();
                            }

                        }

                        WalkDirectoryTree(BackupListEntry);

                        Globals.CfgFile.CurrentEntry = counter + 1;
                        MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);

                        if (SingleStep)
                            break;

                    }
                    counter++;

                }
            }

            // Wenn "BackupCfg.xml" abgearbeitet wurde, CfgFile.CurrentEntry wieder auf 0 setzen
            if (counter >= Globals.CfgFile.CurrentEntry)
            {
                Globals.CfgFile.CurrentEntry = 0;
                MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
                //listBox1.Items.Clear();
                //listBox1.Items.Add("====>     Backup-Liste wird von vorne abgearbeitet");
            }
        }

        /// <summary>
        /// Einfaches Testprogramm
        /// - Die Datei Test 1.txt wird kopiert, wenn es eine neuere Version gibt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileCopy_Click(object sender, EventArgs e)
        {



            string curFile = @"D:\Eigene Dateien\Test\Test 1.txt";
            string targetFile = @"D:\Test Backup Server\Test\Test 1.txt";

            GenerateFileNames(curFile, BasisDirSource, BasisDirTarget);


            if (!File.Exists(targetFile))
            {
                //targetFile = Path.Combine(targetFolder.FullName, System.IO.Path.GetFileName(curFile));
                if (!Directory.Exists(@"D:\Test Backup Server\Test"))
                {
                    Directory.CreateDirectory(@"D:\Test Backup Server\Test");
                }

                System.IO.File.Copy(curFile, targetFile);
            }
            else
            {
                DateTime CurFileModification = File.GetLastWriteTime(curFile);
                DateTime TargetFileModification = File.GetLastWriteTime(targetFile);
                if (TargetFileModification < CurFileModification)
                {
                    //Directory.CreateDirectory(DOCORDNER)
                    File.Delete(targetFile);
                    System.IO.File.Copy(curFile, targetFile);
                    ;
                }
            }
        }


        private void CopyFile(FileInfo SourceFile, FileInfo TargetFile)
        {
            if (!TargetFile.Exists)
            {
                if (!TargetFile.Directory.Exists)
                {
                    TargetFile.Directory.Create();

                }
                FilesChanged++;
                lblFilesChanged.Text = FilesChanged.ToString();
                lblFilesChanged.Update();

                if (FlagListChangedFiles && !FlagListAllFiles)
                {
                    listBox1.Items.Add(SourceFile.FullName);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.Update();
                }

                SourceFile.CopyTo(TargetFile.FullName);
            }
            else
            {
                if (SourceFile.LastWriteTime > TargetFile.LastWriteTime)
                {
                    FilesChanged++;
                    lblFilesChanged.Text = FilesChanged.ToString();
                    lblFilesChanged.Update();

                    if (FlagListChangedFiles && !FlagListAllFiles)
                    {
                        listBox1.Items.Add(SourceFile.FullName);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.Update();
                    }

                    TargetFile.Delete();
                    SourceFile.CopyTo(TargetFile.FullName);
                }

            }
        }




        private String GenerateFileNames(string SourceFillFullPath, string BasisDirSource, string BasisDirTarget)
        {
            int lenDirSource = BasisDirSource.Length;
            int lenDirBackup = BasisDirTarget.Length;

            string FileName = SourceFillFullPath.Substring(lenDirSource);
            string TargetFileFullPath = Path.Join(BasisDirTarget, FileName);

            return (TargetFileFullPath);

        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            Globals.CfgFile = new BackupConfig();

            Globals.CfgFile.Anzahl = 123;
            Globals.CfgFile.BasisDirSource = BasisDirSource;
            Globals.CfgFile.BasisDirTarget = BasisDirTarget;

            Globals.CfgFile.BackupList.Add(BasisDirSource); // adding elements using add() method
            Globals.CfgFile.BackupList.Add(BasisDirTarget);

            Globals.CfgFile.Flags.FlagAutoStart = true;
            Globals.CfgFile.Flags.FlagDisplayAllFiles = false;
            Globals.CfgFile.Flags.FlagDisplayChangedFiles = false;

            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            Globals.CfgFile = (BackupConfig)MWTools.Tools.DeserializeFromXmlFile(Globals.BackupTask, Globals.CfgFile.GetType(), Encoding.Default);

            foreach (string line in Globals.CfgFile.BackupList)
            {
                int a = 1;
            }
        }

        private void Ablauftimer_Tick(object sender, EventArgs e)
        {

            if (chkAutomatic.Checked)
            {
                Ablauftimer.Enabled = false;

                btnStartBackup.Text = "...Running...";
                btnStartBackup.Update();

                FilesChanged = 0;
                lblFilesChanged.Text = FilesChanged.ToString();
                lblFilesChanged.Update();


                //====================================================================
                Ablauf();
                //====================================================================

                DisplaySeconds = 0;
                btnStartBackup.Text = "Start Backup";
                btnStartBackup.Update();

                Ablauftimer.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSelectSourcePath_Click(object sender, EventArgs e)
        {
            int a = 1;
        }

        private void toolStripOpenOrder_Click(object sender, EventArgs e)
        {
            // optional filter to restrict file types
            openFileDialog1.Filter = "BackUp-Auftrag|*.XML";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Globals.BackupTask = openFileDialog1.FileName;

                Globals.CfgFile = new BackupConfig();
                Globals.CfgFile = (BackupConfig)MWTools.Tools.DeserializeFromXmlFile(Globals.BackupTask, Globals.CfgFile.GetType(), Encoding.Default);

                BasisDirSource = Globals.CfgFile.BasisDirSource;
                BasisDirTarget = Globals.CfgFile.BasisDirTarget;

                txtSourceBaseDir.Text = BasisDirSource;
                txtTargetBaseDir.Text = BasisDirTarget;

                SingleStep = Globals.CfgFile.SingleStep;
                chkSingleStep.Checked = SingleStep;

                btnStartBackup.Enabled = true;
                this.Text = Globals.BackupTask;
            }

        }

        private void toolStripEdtTast_Click(object sender, EventArgs e)
        {


        }
        private void chkAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            AutoLoop = chkAutomatic.Checked;
            Globals.CfgFile.Flags.FlagAutoLoop = AutoLoop;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
            Ablauftimer.Enabled = AutoLoop;
        }

        private void chkAutostart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart = chkAutostart.Checked;
            Globals.CfgFile.Flags.FlagAutoStart = AutoStart;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
        }

        private void chkDisplayAllFiles_CheckedChanged(object sender, EventArgs e)
        {
            FlagListAllFiles = chkDisplayAllFiles.Checked;
            Globals.CfgFile.Flags.FlagDisplayAllFiles = FlagListAllFiles;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
        }

        private void chkDisplayChangedFiles_CheckedChanged(object sender, EventArgs e)
        {
            FlagListChangedFiles = chkDisplayChangedFiles.Checked;
            Globals.CfgFile.Flags.FlagDisplayChangedFiles = FlagListChangedFiles;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
        }

        private void DiplayTimer_Tick(object sender, EventArgs e)
        {
            CpuUsage = CpuUsage + cpuCounter.NextValue();

            if (CntMeanValue >= 10)
            {
                lblCpuUsage.Text = (CpuUsage / 10).ToString("N0") + " %";

                CpuUsage = 0;
                CntMeanValue = 0;
            }

            CntMeanValue++;

            if (Ablauftimer.Enabled)
            {
                DisplaySeconds++;
                string DisplayString = ((Ablauftimer.Interval - DisplaySeconds * 100) / 1000).ToString();
                lblTime.Text = DisplayString;
                lblTime.Update();


            }
            else
            {
                DisplaySeconds = 0;
            }

        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            WaitingTime = Convert.ToInt32(txtTime.Text);
            Globals.CfgFile.WaitingTime = WaitingTime;
            MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);

            Ablauftimer.Interval = WaitingTime * 1000;
        }

        private void toolStriDisplayOrder_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();

        }
    }
}

