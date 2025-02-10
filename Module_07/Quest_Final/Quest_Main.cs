using System;
using Module_07.Quest_Final.Delivery;


namespace Module_07.Quest_Final;

public class Quest_Main
{
    /**
    1. Клиент начал оформлять заказ -> Создается Order
    2. Заказ создается по типу доставки
    **/

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается финальное задание модуля 07===");
        Console.WriteLine();

        Console.WriteLine("Добро пожаловать!");
        HomeDelivery homeDelivery = new HomeDelivery();
        PickPointDelivery pickPointDelivery = new PickPointDelivery(Store.Store.PickPoints, 7);
        ResDelivery resDelivery = new ResDelivery(Store.Store.ResAddress);

    }
}
