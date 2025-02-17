using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Quest_937;

internal class Quest_937
{
    delegate void ShowMessageDelegate();
    delegate int SumDelegate(int a, int b, int c);
    delegate bool CheckLengthDelegate(string _row);

    static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }

    internal static void Run()
    {
        //Метод ShowMessage ничего не возвращает, поэтому используем делегат Action
        //ShowMessageDelegate showMessage = ShowMessage;
        Action showMessage = ShowMessage;

        //Метод Sum принимает три параметра и один возвращает, поэтому используем делегат Func
        //SumDelegate sum = Sum;
        Func<int, int, int, int> sum = Sum;

        //Метод CheckLength возвращает булевое значение, поэтому используем Predicat
        //CheckLengthDelegate checkLength = CheckLength;
        Predicate<string> checkLength = CheckLength;

        showMessage();
        Console.WriteLine();

        var resSum = sum(13, 7, 21);
        Console.WriteLine(resSum);
        Console.WriteLine();

        var resCheck = checkLength("Привет");
        Console.WriteLine(resCheck);

    }
}
