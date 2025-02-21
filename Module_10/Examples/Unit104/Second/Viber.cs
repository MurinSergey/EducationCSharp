using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.Second
{
    class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public void GetInfo(T device)
        {
            Console.WriteLine(device);
        }
    }
}
