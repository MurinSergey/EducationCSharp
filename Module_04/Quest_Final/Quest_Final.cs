using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04.Quest_Final
{
    internal class Quest_Final
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается финальное задание модуля 04===");

            (string FirstName, 
                string LastName, 
                string Login, 
                int LoginLength, 
                bool HasPet, 
                double Age, 
                string[] Color) User;

            User.Color = new string[3];

            Console.Write("<<<Введите ваше имя: ");
            User.FirstName = Console.ReadLine();

            Console.Write("<<<Введите вашу фамилию: ");
            User.LastName = Console.ReadLine();

            Console.Write("<<<Введите ваш логин: ");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.Write("<<<Есть ли у вас животные? Да или Нет: ");
            User.HasPet = Console.ReadLine() == "Да" ? true : false;

            Console.ReadKey();
        }
    }
}
