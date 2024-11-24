using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01.Quest_152
{
    internal class Quest_152
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задние 1.5.2===");
            Console.WriteLine("Как вас зовут?");
            var UserName = Console.ReadLine();
            Console.WriteLine($"Приятно познакомится, {UserName}");
        }
    }
}
