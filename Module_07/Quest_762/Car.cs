using System;

namespace Module_07.Quest_762;

public abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public abstract void ChangePart<TCarPart>(TCarPart part) where TCarPart : CarPart;
}
