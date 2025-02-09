using System;

namespace Module_07.Quest_Final.Delivery;

public class PickPointDelivery : Delivery
{
    private List<string> _pickPoints;

    public PickPointDelivery(List<string> pickPoints) : base(DeliveryType.PickPoint)
    {
        _pickPoints = pickPoints;
        SetupAddress();
        SetupDeliveryDateTime();
    }


    protected override void SetupAddress()
    {
        foreach (string pickPoint in _pickPoints)
        {
            Console.WriteLine(pickPoint);
        }
    }

    protected override void SetupDeliveryDateTime()
    {
        throw new NotImplementedException();
    }
}
