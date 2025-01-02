using System;

namespace Module_07.Quest_759;

public class Quest_759
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 7.5.9===");

        int num1 = 7;
        int num2 = -13;
        int num3 = 0;

        Console.WriteLine(num1.GetNegative()); //-7
        Console.WriteLine(num1.GetPositive()); //7
        Console.WriteLine(num2.GetNegative()); //-13
        Console.WriteLine(num2.GetPositive()); //13
        Console.WriteLine(num3.GetNegative()); //0
        Console.WriteLine(num3.GetPositive()); //0
    }
}
