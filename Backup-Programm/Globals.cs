using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Backup_Programm
{

    public static class Globals
    {
        public static int myInt;
        public static string BackupTask = @"D:\BackupCfg.xml";
        public static BackupConfig CfgFile = new BackupConfig();

 

    }


}
