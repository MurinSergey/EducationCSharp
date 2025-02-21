using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1023
{
    class Robot : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Робот - это тоже рабочий");
        }
    }
}
