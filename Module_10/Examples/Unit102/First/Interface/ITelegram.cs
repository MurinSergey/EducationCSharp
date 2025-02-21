using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit102.First.Interface
{
    internal interface ITelegram
    {
        /// <summary>
        /// Отправляет сообщение
        /// </summary>
        /// <param name="msg">Текст сообщения</param>
        internal void SendMessage(string msg);
    }
}
