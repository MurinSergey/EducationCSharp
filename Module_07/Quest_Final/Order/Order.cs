using System;

namespace Module_07.Quest_Final.Order;

public class Order<TDelivery, TStruct> where TDelivery : Delivery.Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    /// <summary>
    /// Список продуктов в заказе
    /// </summary>
    public List<Product.Product> Products; 

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

}
