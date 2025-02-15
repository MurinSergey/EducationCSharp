using System;

namespace Module_07.Quest_753;

public class Quest_753
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 7.5.3===");
        int a = 58;
        int b = 4;
        Console.WriteLine($"a = {a} b = {b}");
        Helper.Swap(ref a, ref b);
        Console.WriteLine($"a = {a} b = {b}");
    }
}
