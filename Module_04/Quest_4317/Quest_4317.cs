using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4317
{
    internal class Quest_4317
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.17===");

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сортируем матрицу");
            var cols = arr.GetLength(1); //Количество стобцов двумерного массива
            for (int i = 0; i < arr.Length; i++) { 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i / cols, i % cols] > arr[j / cols, j % cols]) {
                        (arr[i / cols, i % cols], arr[j / cols, j % cols]) = (arr[j / cols, j % cols], arr[i / cols, i % cols]);
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
