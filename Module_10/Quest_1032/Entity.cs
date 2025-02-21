using Module_10.Quest_1031.Interface;
using Module_10.Quest_1032.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1032
{
    class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(ICreatable).Name}");
        }

        public void Delete()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(IDeletable).Name}");
        }

        public void Update()
        {
            Console.WriteLine($"Не явно реализованный интерфейс {typeof(IUpdatable).Name}");
        }
    }
}
