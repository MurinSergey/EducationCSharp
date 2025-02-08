using System;

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
        bool isMenu = Store.Store.StoreMenu.PrintMenu();
        if (isMenu)
        {
            Console.WriteLine("Выберите продукт, используя порядковый номер или введите \"ОФОРМИТЬ\" для оформления заказа: ");
            Console.WriteLine(Store.Store.StoreMenu[0].GetInfo());
            Console.WriteLine(Store.Store.StoreMenu[^1].GetInfo());
        } else
        {
            Console.WriteLine("Зайдите позже.");
        }

    }
}
