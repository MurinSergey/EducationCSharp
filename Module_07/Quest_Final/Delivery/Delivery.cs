using System;
using System.Globalization;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public abstract class Delivery
{
    /// <summary>
    /// ������ ��������
    /// </summary>
    private string _address;
    /// <summary>
    /// ����� ��������
    /// </summary>
    private DateTime _deliveryDateTime;

    private DeliveryType _deliveryType;

    public string Address
    {
        get { return _address; }
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("����� �������� �� ����� ���� ������.");
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
                throw new ArgumentException("���� �������� ������ ���� �� ���� ������ ��������");
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
                    throw new ArgumentException("���� �������� ������ ���� �� ���� ������ ��������");
                }
                
            }
            else
            {
                throw new ArgumentException("����� �������� �� ������� ��� �� ������������� ���������� ������� \"dd-MM-yyyy HH-mm\"");
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
        Console.WriteLine();
        ConsoleUtils.WriteLine($"��� ������: {DeliveryType.ToRussinaString()}");
    }
    /// <summary>
    /// ����� ��� ������� �������
    /// </summary>
    protected abstract void SetupAddress();
    /// <summary>
    /// ����� ��� ������� ������� ��������
    /// </summary>
    protected abstract void SetupDeliveryDateTime();
    /// <summary>
    /// ������� ��� ���������� � ��������
    /// </summary>
    public abstract void PrintInfo();
    /// <summary>
    /// ��������� ���������� ��������
    /// </summary>
    public virtual void Run()
    {
        Console.WriteLine();
        ConsoleUtils.WriteLine("������ ��������:");
        PrintInfo();
        Console.WriteLine();
        ConsoleUtils.WriteLine("������ ���������!!!");
    }
}
