using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_555
{
    internal class Quest_555
    {
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.5.5===");

            Console.Write("<<<Факториал числа: ");
            var num = int.Parse(Console.ReadLine());
            Console.Write($">>>Факториал {num} равен: {Factorial(num)}");
        }
    }
}
