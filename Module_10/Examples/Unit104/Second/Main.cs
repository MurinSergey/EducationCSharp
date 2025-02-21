using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.Second
{
    class Main
    {
        internal static void Run()
        {
            IMessenger<Phone> viberPhone = new Viber<Phone>();
            viberPhone.GetInfo(new Phone());

            IMessenger<IPhone> viberIPhone = new Viber<IPhone>();
            viberIPhone.GetInfo(new IPhone());

            IMessenger<IPhone> messenger = new Viber<Phone>();
            messenger.GetInfo(new IPhone());
        }

        
    }
}
