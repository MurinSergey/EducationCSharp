using Module_10.Quest_1033.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1033
{
    class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {
            Console.WriteLine($"Явно реализованный интерфейс: {typeof(IBook).Name} Метод: Read Класс: {this.GetType().Name}");
        }

        void IDevice.TurnOff()
        {
            Console.WriteLine($"Явно реализованный интерфейс: {typeof(IDevice).Name} Метод: TurnOff Класс: {this.GetType().Name}");
        }

        void IDevice.TurnOn()
        {
            Console.WriteLine($"Явно реализованный интерфейс: {typeof(IDevice).Name} Метод: TurnOn Класс: {this.GetType().Name}");
        }
    }
}
