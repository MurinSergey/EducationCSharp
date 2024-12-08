using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4315
{
    internal class Quest_4315
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.15===");

            var arr = new int[] { 1, -5, 5, 77, -55, 7, 123, -444 };

            var count = 0;
            foreach (var item in arr) { 
                if (item >= 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество положительных чисел: {count}");
        }
    }
}
