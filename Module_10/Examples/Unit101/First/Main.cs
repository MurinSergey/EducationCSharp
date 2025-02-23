using Module_10.Examples.Unit101.First.app;
using Module_10.Examples.Unit101.First.app.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit101.First
{
    class Main
    {
        internal static void Run()
        {
            ILogger logger = new Logger();

            Woker woker1 = new(logger) { Name = "Рабочий 1" };
            Woker woker2 = new(logger) { Name = "Рабочий 2" };
            Woker woker3 = new(logger) { Name = "Рабочий 3" };

            woker1.Work();
            woker2.Work();
            woker3.Work();
        }
    }
}
