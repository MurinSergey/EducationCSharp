using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1022
{
    class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Явно реализованный интерфейс");
        }
    }
}
