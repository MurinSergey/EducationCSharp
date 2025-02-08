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
        bool isOrder = false;
        while (true)
        {
            Console.WriteLine("Вы хотите что-то заказать? (Да или Нет): ");
            if (Console.ReadLine() is string answer && !string.IsNullOrWhiteSpace(answer) && (answer.ToLower().Equals("да") || answer.ToLower().Equals("нет")))
            {
                if (answer.ToLower().Equals("да"))
                {
                    isOrder = true;
                    break;

                }
                else if (answer.ToLower().Equals("нет"))
                {
                    isOrder = false;
                    Console.WriteLine("До свидания.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Я вас не понимаю.");
            }
        }

        while (isOrder)
        {
            Console.WriteLine("Для вас доступны: ");
            var deliveries = Enum.GetValues<DeliveryType>();
            foreach (var delivery in deliveries)
            {
                Console.WriteLine($"\t{(int)delivery + 1}. {delivery.ToRussinaString()}");
            }
            Console.WriteLine("Выберите вид заказа, используя порядковый номер или введите \"ОТМЕНА\" для отмены заказа: ");
            if (Console.ReadLine() is string answer && !string.IsNullOrWhiteSpace(answer) && (answer.ToLower().Equals("отмена") || (int.TryParse(answer, out int value) && value > 0 && value <= deliveries.Length)))
            {

            }
            else
            {
                Console.WriteLine("Я вас не понимаю.");
            }
        }
        bool isMenu = Store.Store.StoreMenu.PrintMenu();

        if (isMenu)
        {

            // while (true)
            // {

            //     Console.WriteLine("Выберите продукт, используя порядковый номер или введите \"ОФОРМИТЬ\" для оформления заказа: ");
            // }
        }
        else
        {
            Console.WriteLine("Зайдите позже.");
        }

    }
}
