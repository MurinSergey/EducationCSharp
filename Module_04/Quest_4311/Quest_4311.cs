using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4311
{
    internal class Quest_4311
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.11===");

            int[,] arr = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int cols = 0;  cols < arr.GetUpperBound(1) + 1; cols++)
            {
                for (int row = 0; row < arr.GetUpperBound(0) + 1; row++)
                {
                    Console.Write(arr[row, cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
