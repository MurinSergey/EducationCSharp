using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_443
{
    internal class Quest_443
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.4.3===");

            var (myName, myAge) = ("Сергей", 35); //Простая запись кортежа
            (string? name, int age) anketa; //Кортеж

            Console.WriteLine($">>>Меня зовут: {myName}");
            Console.WriteLine($">>>Мой возраст: {myAge}");

            Console.Write($"<<<Введите ваше имя: ");
            //var name = Console.ReadLine();
            anketa.name = Console.ReadLine();

            Console.Write("<<<Введите ваш возраст: ");
            //var age = checked((byte)int.Parse(Console.ReadLine()));
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Вас зовут {0} и вам {1} лет", anketa.name, anketa.age);

            Console.ReadKey();
        }
    }
}
