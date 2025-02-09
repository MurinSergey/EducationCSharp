using System;

namespace Module_07.Quest_Final.Delivery;

public class HomeDelivery : Delivery
{
    /// <summary>
    /// Имя получателя
    /// </summary>
    private string _userName;

    public HomeDelivery() : base(DeliveryType.Home)
    {

        SetupUserName();
    }

    public string UserName
    {
        get { return _userName; }
        set { 
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Имя получателя доставки не может быть пустым.");
            }
            _userName = value;
        }
    }
    /// <summary>
    /// Задаем адрес доставки на дом
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine($"{outPrefix}Пожалуйста введите адрес доставки:");
            Console.Write($"{inPrefix}");
            try
            {
                Address = Console.ReadLine();
                Console.WriteLine($"{outPrefix}Спасибо, доставка по адресу: {Address}");
                break;
            }
            catch (ArgumentException err) {
                Console.WriteLine($"{outPrefix}{err.Message}");
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
            Console.WriteLine($"{outPrefix}Пожалуйста введите желаемую дату и время доставки в формате \"dd-MM-yyyy HH-mm\":");
            Console.Write($"{inPrefix}");
            try
            {
                DeliveryDateTimeString = Console.ReadLine();
                Console.WriteLine($"{outPrefix}Спасибо, доставка на: {DeliveryDateTimeString}");
                break;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine($"{outPrefix}{err.Message}");
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
            Console.WriteLine($"{outPrefix}Пожалуйста введите имя получателя:");
            Console.Write($"{inPrefix}");
            try
            {
                UserName = Console.ReadLine();
                Console.WriteLine($"{outPrefix}Спасибо, доставку получит: {UserName}");
                break;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine($"{outPrefix}{err.Message}");
            }
        }
    }
    /// <summary>
    /// Запускаем выполнение доставки
    /// </summary>
    public override void Run()
    {
        base.Run();
        Console.WriteLine($"{outPrefix}Получатель: {UserName}");
    }
}
