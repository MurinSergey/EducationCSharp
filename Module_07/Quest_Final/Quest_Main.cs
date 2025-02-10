using System;
using Module_07.Quest_Final.Delivery;
using Module_07.Quest_Final.Utils;


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

        ConsoleUtils.WriteLine("Добро пожаловать!");
        bool isOrder = false;
        while (true)
        {
            ConsoleUtils.WriteLine("Хотите сделать заказ?:");
            var answer = ConsoleUtils.ReadLine("(Да/Нет): ");
            if (!string.IsNullOrWhiteSpace(answer) && (answer.ToLower().Equals("да") || answer.ToLower().Equals("нет")))
            {
                if (answer.ToLower().Equals("нет"))
                {
                    isOrder = false;
                }
                else
                {
                    isOrder = true;
                }
                break;
            }
            else
            {
                ConsoleUtils.WriteLine("Я вас не понимаю.");
            }
        }
        if (isOrder) {
            List<Product.Product> products = [];
            Order.Order? order = null;
            while (Store.Store.StoreMenu.PrintMenu())
            {
                Console.WriteLine();
                ConsoleUtils.WriteLine($"В вашем заказе сейчас: {products.Count} пунктов");
                ConsoleUtils.WriteLine("Добавляйте продукт в заказ, указав его порядковый номер или введите \"Оформить\": ");
                var answer = ConsoleUtils.ReadLine("Номер продукта или команда \"Оформить\": ");
                if (int.TryParse(answer, out int parseIndex) && parseIndex >= 0 && parseIndex <= Store.Store.StoreMenu.Count)
                {
                    products.Add(Store.Store.StoreMenu[parseIndex - 1]);
                }
                else if (!string.IsNullOrWhiteSpace(answer) && answer.ToLower().Equals("оформить"))
                {
                    if (products.Count > 0)
                    {
                        while (true)
                        {
                            Console.WriteLine();
                            ConsoleUtils.WriteLine("Выберите тип заказа, указав его порядковый номер: ");
                            var deliveryTypies = Enum.GetValues(typeof(DeliveryType));
                            foreach (DeliveryType deliveryType in deliveryTypies)
                            {
                                Console.WriteLine($"{(int)deliveryType + 1}. {deliveryType.ToRussinaString()}");
                            }
                            if (int.TryParse(ConsoleUtils.ReadLine("Номер: "), out int parseIndexType) && parseIndexType >= 0 && parseIndexType < deliveryTypies.Length)
                            {
                                DeliveryType deliveryType = (DeliveryType)parseIndexType - 1;

                                switch (deliveryType)
                                {
                                    case DeliveryType.Home:
                                        HomeDelivery homeDelivery = new HomeDelivery();
                                        order = new Order.DeliveryOrder<HomeDelivery>(homeDelivery, products);
                                        break;
                                    case DeliveryType.PickPoint:
                                        PickPointDelivery pickPointDelivery = new PickPointDelivery(Store.Store.PickPoints, 7);
                                        order = new Order.DeliveryOrder<PickPointDelivery>(pickPointDelivery, products);
                                        break;
                                    case DeliveryType.ResDelivery:
                                        ResDelivery resDelivery = new ResDelivery(Store.Store.ResAddress);
                                        order = new Order.DeliveryOrder<ResDelivery>(resDelivery, products);
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                ConsoleUtils.WriteLine("Я вас не понимаю.");
                            }
                        }
                        break;
                    }
                    else
                    {
                        ConsoleUtils.WriteLine("Вы не добавили продукты в заказ.");
                    }
                    
                }    
                else
                {
                    ConsoleUtils.WriteLine("Я вас не понимаю.");
                }
            }
            if (order != null)
            {
                Console.WriteLine();
                ConsoleUtils.WriteLine("Вы успешно оформили заказ.");
                order.PrintOrderInfo();
                order.Run();
            }
            else
            {
                ConsoleUtils.WriteLine("Ваш заказ утерян в процессе оформления. Повторите процедуру оформления.");
            }
        }
        ConsoleUtils.WriteLine("Всего хорошего.");

    }
}
