using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4313
{
    internal class Quest_4313
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.13===");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            var sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
