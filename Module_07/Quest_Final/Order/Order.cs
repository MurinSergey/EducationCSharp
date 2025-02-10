using Module_07.Quest_Final.Delivery;
using Module_07.Quest_Final.Utils;
using System;

namespace Module_07.Quest_Final.Order;

public abstract class Order
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
    /// Список продуктов в заказе
    /// </summary>
    private List<Product.Product> _products;


    public Order(List<Product.Product> products)
    {
        _number = ++_ordersCounter;
        _products = products;
    }

    public void PrintProductInfo()
    {
        if (_products.Count > 0)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("В текущем заказе следующие продукты:");
            decimal price = 0;
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_products[i].GetInfo()}");
                price += _products[i].Price;
            }
            ConsoleUtils.WriteLine($"Общая сумма заказа: {price} руб.");
        }
        else
        {
            ConsoleUtils.WriteLine("В текущем заказе нет продуктов.");
        }
    }

    public virtual void PrintOrderInfo()
    {
        ConsoleUtils.WriteLine($"Ваш заказ под номером: {Number}");
        PrintProductInfo();
    }

    public abstract void Run();
}
