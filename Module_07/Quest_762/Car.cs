using System;

namespace Module_07.Quest_762;

public class Car<T1> where T1 : Engine
{
    public T1 Engine;

    public void ChangePart<T2>(T2 part) where T2 : Part { }
}
