using System;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class HomeDelivery : Delivery
{
    /// <summary>
    /// Имя получателя
    /// </summary>
    private string _userName;
    public string UserName
    {
        get { return _userName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Имя получателя доставки не может быть пустым.");
            }
            _userName = value;
        }
    }
    public HomeDelivery() : base(DeliveryType.Home)
    {
        SetupAddress();
        SetupDeliveryDateTime();
        SetupUserName();
        //Run();
    }


    /// <summary>
    /// Задаем адрес доставки на дом
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("Пожалуйста введите адрес доставки:");
            try
            {
                Address = ConsoleUtils.ReadLine("Адрес: ");
                ConsoleUtils.WriteLine($"Спасибо, доставка по адресу: {Address}");
                break;
            }
            catch (ArgumentException err) {
                ConsoleUtils.WriteLine($"{err.Message}");
            }
        }
    }
    /// <summary>
    /// Задаем дату и время доставки на дом
    /// </summary>
    protected override void SetupDeliveryDateTime()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("Пожалуйста введите желаемую дату и время доставки в формате \"dd-MM-yyyy HH-mm\":");
            try
            {
                DeliveryDateTimeString = ConsoleUtils.ReadLine("Формат \"dd-MM-yyyy HH-mm\": ");
                ConsoleUtils.WriteLine($"Спасибо, доставка на: {DeliveryDateTimeString}");
                break;
            }
            catch (ArgumentException err)
            {
                ConsoleUtils.WriteLine($"{err.Message}");
            }
        }
    }
    /// <summary>
    /// Задаем имя получателя
    /// </summary>
    protected void SetupUserName()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("Пожалуйста введите имя получателя:");
            try
            {
                UserName = ConsoleUtils.ReadLine("Имя получателя: ");
                Console.WriteLine($"{ConsoleUtils.outPrefix}Спасибо, доставку получит: {UserName}");
                break;
            }
            catch (ArgumentException err)
            {
                ConsoleUtils.WriteLine($"{err.Message}");
            }
        }
    }
    protected override void PrintInfo()
    {
        Console.WriteLine();
        ConsoleUtils.WriteLine($"Тип задачи: {DeliveryType.ToRussinaString()}");
        ConsoleUtils.WriteLine($"Адрес доставки: {Address}");
        ConsoleUtils.WriteLine($"Время доставки: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"Получатель: {UserName}");
    }
}
