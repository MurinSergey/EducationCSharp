using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05.Quest_522
{
    internal class Quest_522
    {
        static string ShowColor(string user_name)
        {
            Console.WriteLine($"{user_name}, напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is default!");
                    break;
            }

            return color;
        }
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 5.2.2===");

            (string? name, int age) anketa; //Кортеж

            Console.Write(">>>Как вас зовут? ");
            anketa.name = Console.ReadLine();

            Console.Write(">>>Сколько вам лет? ");
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Вас зовут {0} и вам {1} лет", anketa.name, anketa.age);

            var favcolor = new string[3];
            for (int i = 0; i < 3; i++)
            {
                favcolor[i] = ShowColor(anketa.name);
            }

            Console.WriteLine("Ваши любимые цвета");
            foreach (var fav in favcolor)
            {
                Console.WriteLine(fav);
            }

            Console.ReadKey();
        }
    }
}
