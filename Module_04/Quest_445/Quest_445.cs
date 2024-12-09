using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_445
{
    internal class Quest_445
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 4.4.5===");

            (string? Name, string? Type, double Age, int NameCount) Pet;

            Console.Write("<<<Имя вашего питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("<<<Вид вашего питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("<<<Возраст вашего питомца: ");
            Pet.Age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine($"Вашего питомца зовут {Pet.Name}\n" +
                                $"Ему сейчас {Pet.Age} лет\n" +
                                $"Он {Pet.Type}\n" +
                                $"И длина его имени равна {Pet.NameCount} символов");

            Console.ReadKey();
        }
    }
}
