using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_437
{
    internal class Quest_437
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.7===");

            Console.WriteLine("\nВведите сове имя:");
            var name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--) { 
                Console.Write(name[i]);
            }
        }
    }
}
