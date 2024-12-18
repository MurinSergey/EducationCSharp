using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_5313
{
    internal class Quest_5313
    {
        static int[] GetArrayFromConsole(int num = 5) //необязательный параметр
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sortedasc = SortArrayAsc(array);
            sorteddesc = SortArrayDesc(array);
        }

        static int[] SortArrayDesc(int[] array)
        {
            var arr = SortArrayAsc(array);
            //Сортируем массив от большего к меньшему
            Array.Reverse(arr);
            return arr;
        }

        static int[] SortArrayAsc(int[] array)
        {
            var arr = new int[array.Length];
            for (int i = 0; array.Length > i; i++)
            {
                arr[i] = array[i];
            }

            //Сортируем массив от меньшего к большему
            Array.Sort(arr);
            return arr;
        }

        static void ShowArray(int[] array, bool isSort = false, bool isDesc = false)
        {
            var arr = array;
            SortArray(in arr, out int[] arrDesc, out int[] arrAsc);
            if (isSort)
            {
                if (!isDesc)
                {
                    arr = arrAsc;
                }
                else
                {
                    arr = arrDesc;
                }

            }
            Console.Write(string.Join(" ", arr));
            Console.WriteLine();
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.3.13===");

            Console.Write("<<<Введите расмерность массива: ");
            var num = int.Parse(Console.ReadLine());
            var array = GetArrayFromConsole(num);

            ShowArray(array);
            ShowArray(array, true);
            ShowArray(array, true, true);
        }
    }
}
