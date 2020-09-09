using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace WPFapplauncher
   
{
    class Installs
    {
        public static void Installer(string[] args)
        {

            //or If the application is zip file then comment the above line and use the below one to extract the files
            string extractPath = @"c:\example\extract";
            string zipPath = @"c:\example\result.zip";
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            Process.Start("regfilepath")
        }
    }
}

