using System;

namespace Module_07.Quest_734;

public class Car : Transport
{
    public double Fuel;
    public int Mileage;

    public Car()
    {
        this.Fuel = 50;
        this.Mileage = 0;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public void FillTheCar(){
        this.Fuel = 50;
    }
}
