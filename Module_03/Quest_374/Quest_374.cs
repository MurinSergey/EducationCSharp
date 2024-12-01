using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03.Quest_374
{
    internal class Quest_374
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 3.7.4===");

            Console.Write(">>>Как вас зовут? ");
            string name = Console.ReadLine();
            Console.Write(">>>Сколько вам лет? ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine(">>>Вас зовут {0} и вам {1} лет", name, age);
            Console.Write(">>>Ваш любимый день недели? ");
            DaysOfWeek fday = (DaysOfWeek) byte.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день недели - {0}", fday.ToString());   

        }
    }
}
