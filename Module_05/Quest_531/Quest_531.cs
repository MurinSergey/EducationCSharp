using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_531
{
    internal class Quest_531
    {
        static void ChangeAge(int age)
        {
            age += 1;
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.3.1===");

            Console.Write("<<<Введите ваш возраст:");
            var age = int.Parse(Console.ReadLine());
            ChangeAge(age);
            Console.WriteLine(age);
        }
    }
}
