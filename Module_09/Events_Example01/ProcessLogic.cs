using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Events_Example01
{
    class ProcessLogic
    {
        /// <summary>
        /// Событие описанное на основе шаблонного делегата Action, который принимает на вход текст
        /// </summary>
        public event Action<string>? OnProcessComplete;

        /// <summary>
        /// Запуск процесса
        /// </summary>
        public void Start()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Процес запущен");
            ProcessComplete(this.GetType().Name);
        }

        /// <summary>
        /// Завершение процесса
        /// </summary>
        protected virtual void ProcessComplete(string process)
        {
            OnProcessComplete?.Invoke(process);
        }
    }
}
