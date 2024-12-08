using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_4314
{
    internal class Quest_4314
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.3.14===");

            int[][] arr = new int[3][];

            arr[0] = new int[2] {1, 2};
            arr[1] = new int[3] {1, 2, 3};
            arr[2] = new int[5] {1, 2, 3, 4, 5};

            foreach (var ar in arr) {
                foreach (var i in ar) { 
                    Console.Write(i + " ");
                }
            }
        }
    }
}
