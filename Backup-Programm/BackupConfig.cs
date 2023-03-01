using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_Programm
{
    [Serializable]
    public class BackupConfig
    {
        public string Test1;
        public string Test2;
        public int Anzahl;
        public string BasisDirSource;
        public string BasisDirTarget;
        public int CurrentEntry;
        public bool SingleStep;

        public List<String> BackupList = new List<String>();
    }
}
