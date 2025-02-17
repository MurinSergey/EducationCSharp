using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Quest_932;

internal class Quest_932
{
    private delegate int Calc(int a, int b);

    /// <summary>
    /// Метод вычитаем значение b из a
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// Результат вычитания b и a
    /// </returns>
    private static int Subtract(int a, int b)
    {
        return a - b;
    }

    internal static void Run()
    {
        Calc calc = Subtract;
        var res = calc.Invoke(10, 5);
        Console.WriteLine($"Результат: {res}");
        res = calc(15, 6);
        Console.WriteLine($"Результат: {res}");
    }
}
