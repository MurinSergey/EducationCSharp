using Module_10.Examples.Unit102.First.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit102.First
{
    internal class MessageManager : IWhatsApp, IViber, ITelegram
    {
        void IWhatsApp.SendMessage(string msg)
        {
            Console.WriteLine($"WhatsApp говорит: {msg}");
        }

        void IViber.SendMessage(string msg)
        {
            Console.WriteLine($"Viber говорит: {msg}");
        }

        void ITelegram.SendMessage(string msg)
        {
            Console.WriteLine($"Telegram говорит: {msg}");
        }
    }
}
