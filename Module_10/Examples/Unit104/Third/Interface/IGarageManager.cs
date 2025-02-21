using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.Third.Interface
{
    interface IGarageManager<in T, out K>
    {
        K GetInfo();

        void Add(T transport);
    }
}
