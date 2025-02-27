using System;

namespace HelloUbuntu;

public class Helper
{

}

public class Vehicle
{
    protected Vehicle()
    {
        Console.WriteLine("Vehicle created");
    }
}

public class Car : Vehicle
{
    protected Car()
    {
        Console.WriteLine("Car created");
    }
}

public class Truck : Car
{
    public Truck()
    {
        Console.WriteLine("Truck created");
    }
}