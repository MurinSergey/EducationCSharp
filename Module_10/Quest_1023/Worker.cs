using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1023
{
    class Worker : IWorker
    {
        public void Build()
        {
            Console.WriteLine("Этот рабочий строит дом");
        }
    }
}
