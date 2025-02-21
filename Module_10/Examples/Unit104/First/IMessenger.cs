using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.First
{
    interface IMessenger <out T>
    {
        T GetInfo();
    }
}
