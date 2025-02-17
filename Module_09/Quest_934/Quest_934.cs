using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Quest_934;

internal class Quest_934
{

    private delegate void Calc(int a, int b);

    private static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    private static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    internal static void Run()
    {
        Calc calc = Add;
        calc += Sub;
        calc.Invoke(10, 5);
    }
}
