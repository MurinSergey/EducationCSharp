using System;

namespace Module_06.Quest_628;

public class Rectangle
{
    public int a, b;

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public Rectangle(int a)
    {
        this.a = a;
        this.b = a;
    }
}
