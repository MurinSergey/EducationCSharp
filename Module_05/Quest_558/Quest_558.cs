using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_558
{
    internal class Quest_558
    {
        private static int PowerUp(int N, byte pow)
        {
            if (pow > 1)
            {
                return N * PowerUp(N, (byte)(pow - 1));
            } else if (pow == 0)
            {
                return 1;
            }
            else
            {
                return N;
            }
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.5.8===");

            Console.Write("<<<Число: ");
            var num = int.Parse(Console.ReadLine());
            Console.Write("<<<Степень: ");
            var pow = byte.Parse(Console.ReadLine());
            Console.Write($">>>Ответ: {PowerUp(num, pow)}");
        }
    }
}
