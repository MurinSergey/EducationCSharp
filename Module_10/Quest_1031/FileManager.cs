using Module_10.Quest_1031.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1031
{
    class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(IReader).Name}");
        }

        public void SendEmail()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(IMailer).Name}");
        }

        public void Write()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(IWriter).Name}");
        }
    }
}
