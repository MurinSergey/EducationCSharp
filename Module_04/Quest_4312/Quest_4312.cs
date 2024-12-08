using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4312
{
    internal class Quest_4312
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.12===");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0; i < arr.Length; i++) { 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]); //кортеж
                    }
                } 
            }

            for (int i = 0; i < arr.Length; i++) { 
                Console.Write(arr[i] + " ");
            }
        }
    }
}
