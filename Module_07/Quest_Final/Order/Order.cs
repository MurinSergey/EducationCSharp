using System;

namespace Module_07.Quest_Final.Order;

public class Order<TDelivery> where TDelivery : Delivery.Delivery
{
    /// <summary>
    /// Общее количество заказов
    /// </summary>
    private static int _ordersCounter = 0;
    /// <summary>
    /// Номер текущего заказа
    /// </summary>
    private int _number;
    public int Number
    {
        get { return _number; }
    }
    /// <summary>
    /// Доставка для текущего заказа
    /// </summary>
    private TDelivery _delivery;
    /// <summary>
    /// Список продуктов в заказе
    /// </summary>
    private List<Product.Product> _products;


    public Order(TDelivery delivery)
    {
        _number = ++_ordersCounter;
        _delivery = delivery;
    }


    

    public string Description;



    public void DisplayAddress()
    {

    }

}
