using System;
using System.Globalization;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class PickPointDelivery : Delivery
{
    /// <summary>
    /// Список доуступных пунктов выдачи
    /// </summary>
    private List<string> _pickPoints;
    /// <summary>
    /// Интервал хранения заказа, указан в днях
    /// </summary>
    private int _storageInterval;
    /// <summary>
    /// Время окончания хранения заказа
    /// </summary>
    private DateTime _endStorageDateTime;

    public DateTime EndStorageDateTime
    {
        get { return _endStorageDateTime; }
    }

    public string EndStorageDateTimeString
    {
        get
        {
            return _endStorageDateTime.ToString("dd-MM-yyyy HH-mm");
        }
    }

    public PickPointDelivery(List<string> pickPoints, int storageInterval) : base(DeliveryType.PickPoint)
    {
        _pickPoints = pickPoints;
        _storageInterval = storageInterval;
        SetupAddress();
        SetupDeliveryDateTime();
        //Run();
    }
    /// <summary>
    /// Метод для выбора пункта выдачи
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("Пожалуйста выберите пункт выдачи указав его порядковый номер:");
            for (int i = 0; i < _pickPoints.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_pickPoints[i]}");
            }
            if (ConsoleUtils.ReadLine("Номер: ") is string indexString && !string.IsNullOrWhiteSpace(indexString) && int.TryParse(indexString, out int index) && index > 0 && index <= _pickPoints.Count) 
            {
                try
                {
                    Address = _pickPoints[index - 1];
                    ConsoleUtils.WriteLine($"Спасибо, доставка будет выполнена до пункта выдачи: {Address}");
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
    /// <summary>
    /// Метод для расчета времени доставки и хранения заказа
    /// </summary>
    protected override void SetupDeliveryDateTime()
    {
        DeliveryDateTime = DateTime.Today.Date.AddDays(1).AddHours(10);
        _endStorageDateTime = DeliveryDateTime.AddDays(_storageInterval);
        Console.WriteLine();
        ConsoleUtils.WriteLine($"Доставка будет выполнена: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"Заказ храниться {_storageInterval} дней до: {EndStorageDateTimeString}");
    }
    public override void PrintInfo()
    {
        Console.WriteLine();
        ConsoleUtils.WriteLine($"Тип задачи: {DeliveryType.ToRussinaString()}");
        ConsoleUtils.WriteLine($"Выбранный пункт выдачи: {Address}");
        ConsoleUtils.WriteLine($"Время доставки: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"Заказ хранится до: {EndStorageDateTimeString}");
    }
}
