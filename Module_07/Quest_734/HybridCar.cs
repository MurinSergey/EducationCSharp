using System;

namespace Module_07.Quest_734;

public class HybridCar : Car
{
    public FuelType fuelType;

    public void ChangeFuelType(FuelType fuelType)
    {
        this.fuelType = fuelType;
    }
}
