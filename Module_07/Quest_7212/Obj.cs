using System;
using System.Numerics;

namespace Module_07.Quest_7212;

public class Obj
{
    public int Value;

    public static Obj operator +(Obj obj1, Obj obj2)
    {
        return new Obj
        {
            Value = obj1.Value + obj2.Value
        };
    }

    public static Obj operator -(Obj obj1, Obj obj2)
    {
        return new Obj
        {
            Value = obj1.Value - obj2.Value;
        };
    }
}
