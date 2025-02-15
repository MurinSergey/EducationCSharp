using System;

namespace Module_07.Quest_723;

public class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }

    private int counter;
    public override int Counter
    {
        get => counter;
        set {
            if (value > 0){
                counter = value;
            }
        }
    }
}
