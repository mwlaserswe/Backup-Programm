

// Menu             https://www.c-sharpcorner.com/uploadfile/mahesh/menustrip-in-C-Sharp/
// WalkDirectory    https://learn.microsoft.com/de-DE/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree
// Dir der Anw.     https://dotnet-snippets.de/snippet/das-verzeichnis-der-anwendung-ermitteln/23?utm_content=cmp-true
// File Copy        https://dotnet-snippets.de/snippet/dateilisten-kopieren/1315

//  Backup: z.B. von D:\Eigene Dateien\Test\Text Folder 1      --->   D:\Test Backup Server\Test\Text Folder 1
//  BasisDirSource: D:\Eigene Dateien\
//  BasisDirBackup: D:\Test Backup Server\

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

namespace Backup_Programm
{
    public partial class Form1 : Form
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        string BasisDirSource = @"D:\Eigene Dateien\";
        string BasisDirTarget = @"D:\Test Backup Server\";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Hallo World";
            // Start with drives if you have to search the entire computer.
            string[] drives = System.Environment.GetLogicalDrives();

            listBox1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"D:\Eigene Dateien\Test");
            WalkDirectoryTree(di);

            // Write out all the files that could not be processed.

            // Console.WriteLine("Files with restricted access:");

            foreach (string s in log)
            {
                // Console.WriteLine(s);
            }
        }
        private void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

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

                    listBox1.Items.Add(SourceFile.FullName);
                    listBox1.Update();
                    String TargetFileFullPath = GenerateFileNames (SourceFile.FullName, BasisDirSource, BasisDirTarget);

                    //FileInfo SourceFile = new FileInfo(SourceFillFullPath);
                    FileInfo TargetFile = new FileInfo(TargetFileFullPath);

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnGetOwnDir_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            textBox1.Text = fi.DirectoryName;
            Ablauf();
        }




        private void Ablauf ()
        {
            FileInfo fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            textBox1.Text = fi.DirectoryName;

            string BackupList = fi.DirectoryName + "\\BackupList.txt";

            int counter = 0;
 
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(BackupList))
            {
                if (line != "")
                {
                    listBox1.Items.Add("====>    " + line);

                    DirectoryInfo di = new DirectoryInfo(line);

                    WalkDirectoryTree(di);
                    counter++;
 
                }
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

            GenerateFileNames(curFile,  BasisDirSource,  BasisDirTarget);


            if (! File.Exists(targetFile))
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


        private void CopyFile (FileInfo SourceFile, FileInfo TargetFile)
        {
            if (!TargetFile.Exists )
            {
                if (!TargetFile.Directory.Exists)
                {
                    TargetFile.Directory.Create();
                  
                }
                SourceFile.CopyTo(TargetFile.FullName);
            }
            else
            {
                if(SourceFile.LastWriteTime > TargetFile.LastWriteTime)
                {
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
            string TargetFileFullPath = Path.Join(BasisDirTarget,FileName);

            return (TargetFileFullPath);

        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i=0; i<10000; i++)
            {
                listBox1.Items.Add("Test " + i.ToString());
                listBox1.Update();
            }
        }
    }

}

