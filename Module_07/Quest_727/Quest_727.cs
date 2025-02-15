using System;

namespace Module_07.Quest_727;

public class Quest_727
{
    private class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Class A");
        }
    }
    private class B : A
    {
        public new void Display()
        {
            Console.WriteLine("Class B");
        }
    }
    private class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Class C"); //Тут просто проверка
        }
    }
    private class D : B
    {
        public new void Display()
        {
            Console.WriteLine("Class D");
        }
    }
    private class E : C
    {
        public new void Display()
        {
            Console.WriteLine("Class E");
        }
    }

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 7.2.7===");

        D d = new();
        E e = new();

        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }
}