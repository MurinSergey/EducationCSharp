using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1031
{
    class Main
    {
        internal static void Run()
        {
            FileManager fileManager = new();
            fileManager.Write();
            fileManager.Read();
            fileManager.SendEmail();
        }
    }
}
