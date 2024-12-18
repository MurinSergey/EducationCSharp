using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_538
{
    internal class Quest_538
    {
        static int[] GetArrayFromConsole(ref int num) //необязательный параметр
        {
            num = 6;
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] array)
        {
            //Сортируем массив
            Array.Sort(array);
            return array;
        }

        static void ShowArray(int[] array, bool isSort = false)
        {
            var arr = array;
            if (isSort)
            {
                arr = SortArray(arr);
            }
            foreach (var item in arr) { Console.WriteLine(item); }
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.3.8===");

            Console.Write("<<<Введите расмерность массива: ");
            var num = int.Parse(Console.ReadLine());
            var array = GetArrayFromConsole(ref num);
            Console.WriteLine($"Размереность массива {num}");
            ShowArray(array, true);
        }
    }
}
