using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Events_Example02
{
    class ConsoleNumberReader
    {

        public event Action<int>? OnEnterNumber;

        /// <summary>
        /// Считывает с консоли число
        /// </summary>
        /// <exception cref="FormatException">Некорректный ввод</exception>
        internal void NumberRead()
        {
            Console.WriteLine("============================");
            Console.Write("Введите число: ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num != 1 && num != 2) throw new FormatException();

            EnterNumber(num);
        }

        /// <summary>
        /// Вызывает событие ввода корректного числа
        /// </summary>
        /// <param name="number">Одно из допустимых чисел</param>
        protected virtual void EnterNumber(int number)
        {
            OnEnterNumber?.Invoke(number);
        }
    }
}
