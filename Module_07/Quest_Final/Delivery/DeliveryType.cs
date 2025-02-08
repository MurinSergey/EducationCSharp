using System;

namespace Module_07.Quest_Final.Delivery;

/// <summary>
/// Виды доставки
/// </summary>
public enum DeliveryType
{
    Home,
    PickPoint,
    RestoranDelivery
}

public static class DeliveryTypeMethon
{
    public static string ToRussinaString(this DeliveryType type)
    {
        return type switch
        {
            DeliveryType.Home => "Доставка домой",
            DeliveryType.PickPoint => "Доставка в пункт выдачи",
            DeliveryType.RestoranDelivery => "Без доставки",
            _ => throw new NotImplementedException()
        };
    }
}

