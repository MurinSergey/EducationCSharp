using Module_10.Quest_1033.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1033
{
    class Main
    {
        internal static void Run()
        {
            IBook book = new ElectronicBook();
            IDevice device = new ElectronicBook();

            device.TurnOn();
            book.Read();
            device.TurnOff();
        }
    }
}
