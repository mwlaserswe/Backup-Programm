using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Programm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // nur ein Test der globalen Variablen
            int myv = Globals.myInt;
            int a = myv;


            // Configuration erneut einlesen, damit man die Liste während des Programmlaufs ändern kann
            Globals.CfgFile = (BackupConfig)MWTools.Tools.DeserializeFromXmlFile(Globals.BackupTask, Globals.CfgFile.GetType(), Encoding.Default);

            FileInfo BackupList = new FileInfo(Assembly.GetEntryAssembly().Location);

            int counter = 0;
            listBoxOrder.Items.Clear();
            //listBox1.Items.Add("====>     Backup-Liste wird von vorne abgearbeitet");

            // Read the Backup listc ine by line.  
            foreach (string line in Globals.CfgFile.BackupList)
            {
                if (line != "")
                {
                    listBoxOrder.Items.Add(line);
                }

            }
            
            // Wenn eine kürzere Auftragsliste geladen wird, wird der erste Eintrag angewählt
            if (Globals.CfgFile.CurrentEntry >= listBoxOrder.Items.Count) 
            {
                listBoxOrder.SelectedIndex = 0;
            }
            else
            {
                listBoxOrder.SelectedIndex = Globals.CfgFile.CurrentEntry;
            }
        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedIndex >= 0)
            {
                Globals.CfgFile.CurrentEntry = listBoxOrder.SelectedIndex;
                MWTools.Tools.SerializeToXmlFile(Globals.CfgFile, Globals.BackupTask, Encoding.Default);
            }
        }
    }
}
