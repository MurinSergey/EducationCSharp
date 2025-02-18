using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Events_Example02
{
    class Main
    {
        internal static void Run()
        {
            ConsoleNumberReader numberReader = new();
            numberReader.OnEnterNumber += PrintResultNumber;
            numberReader.OnEnterNumber += PrintResultText;

            while (true)
            {
                try
                {
                    numberReader.NumberRead();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }

        /// <summary>
        /// Метод печатает результат входных данных
        /// </summary>
        /// <param name="num">Число на распечатку</param>
        internal static void PrintResultNumber(int num)
        {
            string res = num switch
            {
                1 => "Введено корректное значение: 1",
                2 => "Введено корректное значение: 2",
                _ => $"Введено некорректное значение: {num}"
            };
            Console.WriteLine(res);
        }

        internal static void PrintResultText(int num)
        {
            string res = num switch
            {
                1 => "Выбран вариант выполнения 1",
                2 => "Выбран вариант выполнения 2",
                _ => $"Вариант выполнения {num} недоступен"
            };
            Console.WriteLine(res);
        }
    }
}
