using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Events_Example01
{
    class Main
    {
        internal static void Run()
        {
            ProcessLogic process = new();
            process.OnProcessComplete += FinishText;
            process.OnProcessComplete += AgainText;
            process.Start();
        }

        /// <summary>
        /// Печатаем информацию о завершении процесса
        /// </summary>
        /// <param name="process">Имя процесса</param>
        internal static void FinishText(string process)
        {
            Console.WriteLine($"Процес {process} завершен");
        }

        /// <summary>
        /// Печатаем вопрос о перезапуске процесса
        /// </summary>
        /// <param name="process">Имя процесса</param>
        internal static void AgainText(string process)
        {
            Console.WriteLine($"Запустим процес {process} снова?");
        }
    }
}
