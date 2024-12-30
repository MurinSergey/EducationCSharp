using System;

namespace Module_07.Quest_723;

public class Quest_723
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 7.2.3===");

        BaseClass baseClass= new();
        DerivedClass derivedClass = new();

        baseClass.Display();
        derivedClass.Display();
        ((BaseClass)derivedClass).Display();
    }
}
