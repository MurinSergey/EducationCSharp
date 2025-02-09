using System;

namespace Module_07.Quest_Final.Delivery;

/// <summary>
/// Виды доставки
/// </summary>
public enum DeliveryType
{
    Home,
    PickPoint,
    ResDelivery
}

public static class DeliveryTypeMethon
{
    public static string ToRussinaString(this DeliveryType type)
    {
        return type switch
        {
            DeliveryType.Home => "Доставка домой",
            DeliveryType.PickPoint => "Доставка в пункт выдачи",
            DeliveryType.ResDelivery => "Доставка в ресторан",
            _ => throw new NotImplementedException()
        };
    }
}

