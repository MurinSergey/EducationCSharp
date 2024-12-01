using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03.Quest_328
{
    internal class Quest_328
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 3.2.8===");

            const string MY_NAME = "Sergey";

            Console.WriteLine(MY_NAME);

            Console.WriteLine("\t Привет, Мир");
            Console.WriteLine("\t Мне 35 лет");
            Console.WriteLine($"\t Меня зовут {MY_NAME}");
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
