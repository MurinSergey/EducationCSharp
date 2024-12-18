using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_553
{
    internal class Quest_553
    {
        static void Echo(string saidword, int deep)
        {
            if (deep > 1 && saidword.Length > 2) 
            {
                saidword = saidword.Substring(2);
                Console.BackgroundColor = (ConsoleColor)deep;
                Console.WriteLine($"...{saidword}");
                Echo(saidword, --deep);
            }
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.5.3===");

            Console.Write("<<<Введите фразу: ");
            var str = Console.ReadLine();
            Console.Write("<<<Введите глубину эха: ");
            var deep = int.Parse(Console.ReadLine());
            Echo(str, deep);
        }
    }
}
