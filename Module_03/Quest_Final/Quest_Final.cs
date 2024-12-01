using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03.Quest_Final
{
    internal class Quest_Final
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается Финальное задание===");

            Console.Write(">>>Как вас зовут? ");
            var name = Console.ReadLine();

            Console.Write(">>>Сколько вам лет? ");
            var age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Вас зовут {0} и вам {1} лет", name, age);

            Console.Write(">>>Когда вы родились? ");
            var birthday = Console.ReadLine();

            Console.WriteLine($"Вы родились в {birthday}");

            Console.ReadKey();
        }
    }
}
