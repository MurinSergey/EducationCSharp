using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1044
{
    interface IUpdater <in T>
    {
        void Update(T entity);
    }
}
