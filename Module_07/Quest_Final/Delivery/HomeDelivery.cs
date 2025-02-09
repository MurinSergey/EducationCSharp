using System;

namespace Module_07.Quest_Final.Delivery;

public class HomeDelivery : Delivery
{
    /// <summary>
    /// ��� ����������
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
                throw new ArgumentException("��� ���������� �������� �� ����� ���� ������.");
            }
            _userName = value;
        }
    }
    /// <summary>
    /// ������ ����� �������� �� ���
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine($"{outPrefix}���������� ������� ����� ��������:");
            Console.Write($"{inPrefix}");
            try
            {
                Address = Console.ReadLine();
                Console.WriteLine($"{outPrefix}�������, �������� �� ������: {Address}");
                break;
            }
            catch (ArgumentException err) {
                Console.WriteLine($"{outPrefix}{err.Message}");
            }
        }
    }
    /// <summary>
    /// ������ ���� � ����� �������� �� ���
    /// </summary>
    protected override void SetupDeliveryDateTime()
    {
        while (true)
        {
            Console.WriteLine($"{outPrefix}���������� ������� �������� ���� � ����� �������� � ������� \"dd-MM-yyyy HH-mm\":");
            Console.Write($"{inPrefix}");
            try
            {
                DeliveryDateTimeString = Console.ReadLine();
                Console.WriteLine($"{outPrefix}�������, �������� ��: {DeliveryDateTimeString}");
                break;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine($"{outPrefix}{err.Message}");
            }
        }
    }
    /// <summary>
    /// ������ ��� ����������
    /// </summary>
    protected void SetupUserName()
    {
        while (true)
        {
            Console.WriteLine($"{outPrefix}���������� ������� ��� ����������:");
            Console.Write($"{inPrefix}");
            try
            {
                UserName = Console.ReadLine();
                Console.WriteLine($"{outPrefix}�������, �������� �������: {UserName}");
                break;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine($"{outPrefix}{err.Message}");
            }
        }
    }
    /// <summary>
    /// ��������� ���������� ��������
    /// </summary>
    public override void Run()
    {
        base.Run();
        Console.WriteLine($"{outPrefix}����������: {UserName}");
    }
}
