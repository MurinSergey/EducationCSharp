using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Quest_9312;

internal class Quest_9312
{
    delegate void ShowMessageDelegate(string _message);
    internal static void Run()
    {
        //ShowMessageDelegate showMessageDelegate = ShowMessage;
        //ShowMessageDelegate showMessageDelegate = delegate(string _message)
        //{
        //    Console.WriteLine(_message);
        //};
        ShowMessageDelegate showMessageDelegate = (string _message) =>
        {
            Console.WriteLine(_message);
        };
        showMessageDelegate.Invoke("Hello World!");
        Console.Read();
    }

    internal static void ShowMessage(string _message)
    {
        Console.WriteLine(_message);
    }
}
