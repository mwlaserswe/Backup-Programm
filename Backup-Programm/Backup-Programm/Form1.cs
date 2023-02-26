

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

using System.Xml.Serialization;

namespace Backup_Programm
{

    //[Serializable]
    //public class Person
    //{
    //    public string FirstName;
    //    public string LastName;
    //    public DateTime BirthDate;
    //}


    public partial class Form1 : Form
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        string BasisDirSource = @"C:\Temp\";
        string BasisDirTarget = @"D:\Temp\";
        int CurrentEntry = 0;
        bool SingleStep = false;


        BackupConfig CfgFile = new BackupConfig();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Read configuration
            CfgFile = (BackupConfig)DeserializeFromXmlFile(@"D:\BackupCfg.xml", CfgFile.GetType(), Encoding.Default);

            BasisDirSource = CfgFile.BasisDirSource;
            BasisDirTarget = CfgFile.BasisDirTarget;

            txtSourceBaseDir.Text = BasisDirSource;
            txtTargetBaseDir.Text = BasisDirTarget;

            SingleStep = CfgFile.SingleStep;
            chkSingleStep.Checked = SingleStep;

        }

        private void chkSingleStep_CheckedChanged(object sender, EventArgs e)
        {
            SingleStep = chkSingleStep.Checked;
            CfgFile.SingleStep = SingleStep;
            SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);

        }
        private void btnSelectSourcePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BasisDirSource = folderBrowserDialog1.SelectedPath;
                CfgFile.BasisDirSource = BasisDirSource;
                SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);
                txtSourceBaseDir.Text = BasisDirSource;
            }
        }

        private void btnSelectTargetPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BasisDirTarget= folderBrowserDialog1.SelectedPath;
                CfgFile.BasisDirTarget = BasisDirTarget;
                SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);
                txtTargetBaseDir.Text = BasisDirTarget;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ////// Start with drives if you have to search the entire computer.
            ////string[] drives = System.Environment.GetLogicalDrives();

            ////listBox1.Items.Clear();
            ////DirectoryInfo di = new DirectoryInfo(@"D:\Eigene Dateien\Test");
            ////WalkDirectoryTree(di);

            ////// Write out all the files that could not be processed.

            ////// Console.WriteLine("Files with restricted access:");

            ////foreach (string s in log)
            ////{
            ////    // Console.WriteLine(s);
            ////}
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
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.Update();
                    String TargetFileFullPath = GenerateFileNames(SourceFile.FullName, BasisDirSource, BasisDirTarget);

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
            Ablauf();
        }




        private void Ablauf()
        {
            // Configuration erneut einlesen, damit man die Liste während des Programmlaufs ändern kann
            CfgFile = (BackupConfig)DeserializeFromXmlFile(@"D:\BackupCfg.xml", CfgFile.GetType(), Encoding.Default);

            FileInfo BackupList = new FileInfo(Assembly.GetEntryAssembly().Location);
 
            string BackupListFullName = BackupList.DirectoryName + "\\BackupList.txt";

            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(BackupListFullName))
            {
                if (line != "")
                {

                    if (SingleStep)
                    { if (counter == CfgFile.CurrentEntry)
                        {
                            listBox1.Items.Add("====>    " + line);
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;

                            DirectoryInfo BackupListEntry = new DirectoryInfo(line);

                            WalkDirectoryTree(BackupListEntry);

                            CfgFile.CurrentEntry = counter + 1;
                            SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);

                            break;
                        }
                        counter++;

                     }
                    else
                    {
                        listBox1.Items.Add("====>    " + line);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;

                        DirectoryInfo BackupListEntry = new DirectoryInfo(line);

                        WalkDirectoryTree(BackupListEntry);

                        CfgFile.CurrentEntry = counter + 1;
                        SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);
                    }
                }
            }

            // Wenn "BackupCfg.xml" abgearbeitet wurde, CfgFile.CurrentEntry wieder auf 0 setzen
            if (counter >= CfgFile.CurrentEntry)
            {
                CfgFile.CurrentEntry = 0;
                SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);
                listBox1.Items.Clear();
                listBox1.Items.Add("====>     Backup-Liste wird von vorne abgearbeitet");
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
                SourceFile.CopyTo(TargetFile.FullName);
            }
            else
            {
                if (SourceFile.LastWriteTime > TargetFile.LastWriteTime)
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
            string TargetFileFullPath = Path.Join(BasisDirTarget, FileName);

            return (TargetFileFullPath);

        }

        public static void SerializeToXmlFile(object obj, string filename, Encoding encoding)
        {
            // XmlSerializer für den Typ des Objekts erzeugen
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            // Objekt über ein StreamWriter-Objekt serialisieren
            using (StreamWriter streamWriter = new StreamWriter(filename, false, encoding))
            {
                serializer.Serialize(streamWriter, obj);

            }
        }

        public static object DeserializeFromXmlFile(string filename, Type objectType, Encoding encoding)
        {
            // XmlSerializer für den Typ des Objekts erzeugen
            XmlSerializer serializer = new XmlSerializer(objectType);
            // Objekt über ein StreamReader-Objekt serialisieren
            using (StreamReader streamReader = new StreamReader(filename, encoding))
            {
                return serializer.Deserialize(streamReader);
            }
        }
 
        private void btnTests_Click(object sender, EventArgs e)
        {
            //////// Person-Objekt erzeugen
            ////Person person = new Person();
            ////person.FirstName = "Zaphod";
            ////person.LastName = "Beeblebox";
            ////person.BirthDate = new DateTime(1900, 1, 1);

            ////SerializeToXmlFile(person, @"D:\Serialize.xml", Encoding.Default);


            CfgFile.Test1 = "Zeile1";
            CfgFile.Test2 = "Zeile2";
            CfgFile.Anzahl = 123;
            CfgFile.BasisDirSource = BasisDirSource;
            CfgFile.BasisDirTarget = BasisDirTarget;

            SerializeToXmlFile(CfgFile, @"D:\BackupCfg.xml", Encoding.Default);


            ////int a = 1;

        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            CfgFile = (BackupConfig)DeserializeFromXmlFile(@"D:\BackupCfg.xml", CfgFile.GetType(), Encoding.Default);
         }
    }
}

