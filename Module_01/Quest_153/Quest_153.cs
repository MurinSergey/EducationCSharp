using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01.Quest_153
{
    internal class Quest_153
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("===Запускается задние 1.5.3===");
            Console.WriteLine(">>>Как вас зовут?");
            var UserName = Console.ReadLine();
            Console.WriteLine($">>>Приятно познакомится, {UserName}");
            Console.WriteLine($">>>{UserName}, сколько вам лет?");
            var UserAge = Console.ReadLine();
            Console.WriteLine($">>>Прекрасный возраст!");
            Console.WriteLine($">>>{UserName}, вам {UserAge} лет, а когда у вас день рождения?");
            var Birthday = Console.ReadLine();
            Console.WriteLine($">>>{UserName}, я этого не забуду и обязательно вас поздравлю!");
        }
    }
}
