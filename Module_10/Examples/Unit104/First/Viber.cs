using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.First
{
    /*
         Viber<T> — это обобщенный (generic) класс, который принимает тип T.

         IMessenger<T> — это интерфейс, который реализует класс Viber<T>. Это означает, что класс Viber<T> должен реализовать все методы, определенные в интерфейсе IMessenger<T>.

         where T : Phone, new() — это ограничение на тип T:

         T должен быть классом, который наследуется от класса Phone (или быть самим классом Phone).

         T должен иметь конструктор без параметров (благодаря new()).
     */

    class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public T GetInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return device;
        }
    }
}
