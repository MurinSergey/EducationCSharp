using System;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class ResDelivery : Delivery
{
    /// <summary>
    /// Список доступных ресторанов
    /// </summary>
    private List<string> _resAddress;
    /// <summary>
    /// Имя посетителя
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

    public ResDelivery(List<string> resAddress) : base(DeliveryType.ResDelivery)
    {
        _resAddress = resAddress;
        SetupAddress();
        SetupDeliveryDateTime();
        SetupUserName();
        //Run();
    }

    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine($"Пожалуйста выберите ресторан для посещения указав его порядковый номер:");
            for (int i = 0; i < _resAddress.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_resAddress[i]}");
            }
            if (ConsoleUtils.ReadLine("Номер: ") is string indexString && !string.IsNullOrWhiteSpace(indexString) && int.TryParse(indexString, out int index) && index > 0 && index <= _resAddress.Count)
            {
                try
                {

                    Address = _resAddress[index - 1];
                    ConsoleUtils.WriteLine($"Спасибо, доставим заказ в ресторан: {Address}");
                    break;
                }
                catch (ArgumentException err)
                {
                    ConsoleUtils.WriteLine($"{err.Message}");
                }
            }
            else
            {
                ConsoleUtils.WriteLine($"Кажется, ваш выбор не предусмотрен системой.");
            }
        }
    }

    protected override void SetupDeliveryDateTime()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine($"Пожалуйста введите желаемую дату и время посещения ресторана в формате \"dd-MM-yyyy HH-mm\":");
            try
            {
                DeliveryDateTimeString = ConsoleUtils.ReadLine("Формат \"dd-MM-yyyy HH-mm\": ");
                ConsoleUtils.WriteLine($"Спасибо, посещение запланировано на: {DeliveryDateTimeString}");
                break;
            }
            catch (ArgumentException err)
            {
                ConsoleUtils.WriteLine($"{err.Message}");
            }
        }
    }
    /// <summary>
    /// Задаем имя посетителя
    /// </summary>
    protected void SetupUserName()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine($"Пожалуйста введите имя гостя:");
            try
            {
                UserName = ConsoleUtils.ReadLine("Имя гостя: ");
                ConsoleUtils.WriteLine($"Спасибо, столик будет забронирован на: {UserName}");
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
        ConsoleUtils.WriteLine($"Выбранный ресторан: {Address}");
        ConsoleUtils.WriteLine($"Время посещения: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"Гость: {UserName}");
    }
}
