using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_442
{
    internal class Quest_442
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.4.2===");

            (string? name, int age) anketa; //Кортеж

            Console.Write(">>>Как вас зовут? ");
            //var name = Console.ReadLine();
            anketa.name = Console.ReadLine();

            Console.Write(">>>Сколько вам лет? ");
            //var age = checked((byte)int.Parse(Console.ReadLine()));
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Вас зовут {0} и вам {1} лет", anketa.name, anketa.age);

            Console.Write(">>>Когда вы родились? ");
            var birthday = Console.ReadLine();

            Console.WriteLine($"Вы родились в {birthday}");

            Console.ReadKey();
        }
    }
}
