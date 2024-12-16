using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_528
{
    internal class Quest_528
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

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

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.1.6===");

            var array = GetArrayFromConsole();
            array = SortArray(array);
            foreach (var item in array) { Console.WriteLine(item); }
        }
    }
}
