using System;

namespace Module_07.Quest_762;

public class GasCar : Car<GasEngine>
{
    public GasCar()
    {
        Engine = new GasEngine();
    }

    public override void ChangePart<TCarPart>(TCarPart part)
    {
        throw new NotImplementedException();
    }
}
