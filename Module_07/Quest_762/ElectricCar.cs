using System;

namespace Module_07.Quest_762;

public class ElectricCar : Car<ElectricEngine>
{
    public ElectricCar(){
        Engine = new ElectricEngine();
    }

    public override void ChangePart<TCarPart>(TCarPart part)
    {
        throw new NotImplementedException();
    }
}
