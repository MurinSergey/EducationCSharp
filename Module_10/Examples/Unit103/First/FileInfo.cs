using Module_10.Examples.Unit103.First.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit103.First
{
    class FileInfo : IFile, IBinaryFile
    {
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Открываем бинарный файл");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Читаем обычный файл");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Читаем бинарный файл");
        }

        internal void SearchFile(string filterString)
        {
            Console.WriteLine($"Ищем файл: {filterString}");
        }
    }
}
