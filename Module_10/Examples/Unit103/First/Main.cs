using Module_10.Examples.Unit103.First.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit103.First
{
    class Main
    {
        internal static void Run()
        {
            IFile file = new FileInfo();
            IBinaryFile binaryFile = new FileInfo();
            FileInfo fileInfo = new();

            file.ReadFile();

            binaryFile.OpenBinaryFile();
            binaryFile.ReadFile();

            fileInfo.SearchFile("Искомый файл");
        }
    }
}
