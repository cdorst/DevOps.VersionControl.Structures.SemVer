using System;
using System.Collections.Generic;
using System.Text;
using static System.Convert;

namespace DevOps.VersionControl.Structures.SemVer
{
    public struct SemVerVersion
    {
        public SemVerVersion(string version)
        {
            var split = version.Split('.');
            Major = ToInt32(split[0]);
            Minor = ToInt32(split[2]);
            Patch = ToInt32(split[4]);
        }

        public SemVerVersion(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }

        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }

        public string Version => $"{Major}.{Minor}.{Patch}";
    }
}
