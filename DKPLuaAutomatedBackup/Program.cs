using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;


namespace DKPLuaAutomatedBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "MonolithDKP.lua";
            string newFileName = DateTime.Today.ToString("MM-dd-yyyy")+"-MonolithDKP.lua";
            string sourcePath = ConfigurationManager.AppSettings.Get("LuaLocation");
            string targetPath = ConfigurationManager.AppSettings.Get("BackupDestination");
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, newFileName);
            System.IO.File.Copy(sourceFile, destFile, true);
        }
    }
}
