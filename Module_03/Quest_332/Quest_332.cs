using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_03.Quest_332
{
    internal class Quest_332
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задание 3.3.2===");

            const string USER_NAME = "Сергей";
            byte age = 35;
            bool havePet = false;
            float shoeSize = 32;
            Console.WriteLine($"Меня зовут {USER_NAME}");
            Console.WriteLine($"Мне {age} лет");
            Console.WriteLine($"Есть ли у вас домошнее животное? {havePet}");
            Console.WriteLine($"Размер моей обуви {shoeSize}");
        }
    }
}
