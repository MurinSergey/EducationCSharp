using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit101.First.app.Interface
{
    interface ILogger
    {
        void Event(string msg);

        void Error(string err);
    }
}
