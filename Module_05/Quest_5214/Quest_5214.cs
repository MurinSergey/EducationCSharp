﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_5214
{
    internal class Quest_5214
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

        static int[] SortArray(int[] array)
        {
            //Сортируем массив
            Array.Sort(array);
            return array;
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.2.14===");

            var array = GetArrayFromConsole(3);
            var sortedarray = SortArray(array); //Сортированный массив
            foreach (var item in array) { Console.WriteLine(item); }
        }
    }
}