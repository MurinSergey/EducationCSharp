using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4316
{
    internal class Quest_4316
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.16===");

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            var count = 0;
            foreach (var item in arr)
            {
                if (item >= 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество положительных чисел: {count}");
        }
    }
}
