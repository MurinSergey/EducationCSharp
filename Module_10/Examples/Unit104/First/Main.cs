using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.First
{
    class Main
    {
        internal static void Run()
        {
            IMessenger<Phone> phoneViber = new Viber<Phone>();
            IMessenger<IPhone> iphoneViber = new Viber<IPhone>();
            IMessenger<Phone> viber = new Viber<IPhone>();

            Phone phone1 = phoneViber.GetInfo();
            Phone phone2 = iphoneViber.GetInfo();
            Phone phone3 = viber.GetInfo();
        }
    }
}
