using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.Second
{
    interface IMessenger <in T>
    {
        void GetInfo(T device);
    }
}
