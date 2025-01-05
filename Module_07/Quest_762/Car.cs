using System;

namespace Module_07.Quest_762;

public class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public virtual void ChangePart<TCarPart>(TCarPart part) where TCarPart : CarPart { }
}
