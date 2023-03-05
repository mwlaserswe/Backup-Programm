﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_Programm
{
    public struct Flags
    {
        public bool FlagAutoStart;
        public bool FlagDisplayAllFiles;
        public bool FlagDisplayChangedFiles;
    }

    [Serializable]
    public class BackupConfig
    {
        public int Anzahl;
        public string BasisDirSource;
        public string BasisDirTarget;
        public int CurrentEntry;
        public bool SingleStep;
        public Flags Flags;

        public List<String> BackupList = new List<String>();
    }
}
