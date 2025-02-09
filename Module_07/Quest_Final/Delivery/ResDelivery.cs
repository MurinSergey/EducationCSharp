using System;

namespace Module_07.Quest_Final.Delivery;

public class ResDelivery : Delivery
{
    public ResDelivery() : base(DeliveryType.ResDelivery)
    {
        SetupAddress();
        SetupDeliveryDateTime();
    }

    protected override void SetupAddress()
    {
        throw new NotImplementedException();
    }

    protected override void SetupDeliveryDateTime()
    {
        throw new NotImplementedException();
    }
}
