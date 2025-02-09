using System;
using System.Globalization;

namespace Module_07.Quest_Final.Delivery;

public abstract class Delivery
{
    /// <summary>
    /// Адресс доставки
    /// </summary>
    private string _address;

    /// <summary>
    /// Время доставки
    /// </summary>
    private DateTime _deliveryDateTime;

    protected const string outPrefix = ">>>>>>>>";

    protected const string inPrefix = "<<<<";

    private DeliveryType _deliveryType;

    public string Address
    {
        get { return _address; }
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Адрес доставки не может быть пустым.");
            }
            _address = value;
        }
    }

    public DateTime DeliveryDateTime
    {
        get { return _deliveryDateTime; }
        protected set
        {
            if (value < DateTime.Today.AddDays(1))
            {
                throw new ArgumentException("День доставки должен быть на день больше текущего");
            }
            _deliveryDateTime = value;
        }
    }

    public string DeliveryDateTimeString
    {
        get
        {
            return _deliveryDateTime.ToString("dd-MM-yyyy HH-mm");
        }

        protected set
        {
            if (DateTime.TryParseExact(value, "dd-MM-yyyy HH-mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parseDateTime))
            {
                if (parseDateTime >= DateTime.Today.AddDays(1))
                {
                    _deliveryDateTime = parseDateTime;
                }
                else
                {
                    throw new ArgumentException("День доставки должен быть на день больше текущего");
                }
                
            }
            else
            {
                throw new ArgumentException("Время доставки не заданно или не соответствует ожидаемому формату \"dd-MM-yyyy HH-mm\"");
            }
        }
    }

    public DeliveryType DeliveryType
    {
        get { return _deliveryType; }
        private set { 
            _deliveryType = value;
        }
    }

    public Delivery(DeliveryType deliveryType)
    {
        DeliveryType = deliveryType;
        Console.WriteLine($"{outPrefix}Тип задачи: {DeliveryType.ToRussinaString()}");
    }

    /// <summary>
    /// Метод для задания адресса
    /// </summary>
    protected abstract void SetupAddress();
    /// <summary>
    /// Метод для задания времени доставки
    /// </summary>
    protected abstract void SetupDeliveryDateTime();
    /// <summary>
    /// Запускаем выполнение доставки
    /// </summary>
    public virtual void Run()
    {
        Console.WriteLine($"{outPrefix}ЗАДАЧА ЗАПУЩЕНА: {DeliveryType.ToRussinaString()}");
        Console.WriteLine($"{outPrefix}ЗАДАЧА ВЫПОЛНЕНА: {DeliveryType.ToRussinaString()}");
        Console.WriteLine($"{outPrefix}Время доставки: {DeliveryDateTimeString}");
        Console.WriteLine($"{outPrefix}Адрес доставки: {Address}");
    }
}
