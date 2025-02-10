using System;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class HomeDelivery : Delivery
{
    /// <summary>
    /// ��� ����������
    /// </summary>
    private string _userName;
    public string UserName
    {
        get { return _userName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("��� ���������� �������� �� ����� ���� ������.");
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
    /// ������ ����� �������� �� ���
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("���������� ������� ����� ��������:");
            try
            {
                Address = ConsoleUtils.ReadLine("�����: ");
                ConsoleUtils.WriteLine($"�������, �������� �� ������: {Address}");
                break;
            }
            catch (ArgumentException err) {
                ConsoleUtils.WriteLine($"{err.Message}");
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
            Console.WriteLine();
            ConsoleUtils.WriteLine("���������� ������� �������� ���� � ����� �������� � ������� \"dd-MM-yyyy HH-mm\":");
            try
            {
                DeliveryDateTimeString = ConsoleUtils.ReadLine("������ \"dd-MM-yyyy HH-mm\": ");
                ConsoleUtils.WriteLine($"�������, �������� ��: {DeliveryDateTimeString}");
                break;
            }
            catch (ArgumentException err)
            {
                ConsoleUtils.WriteLine($"{err.Message}");
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
            Console.WriteLine();
            ConsoleUtils.WriteLine("���������� ������� ��� ����������:");
            try
            {
                UserName = ConsoleUtils.ReadLine("��� ����������: ");
                Console.WriteLine($"{ConsoleUtils.outPrefix}�������, �������� �������: {UserName}");
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
        ConsoleUtils.WriteLine($"��� ������: {DeliveryType.ToRussinaString()}");
        ConsoleUtils.WriteLine($"����� ��������: {Address}");
        ConsoleUtils.WriteLine($"����� ��������: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"����������: {UserName}");
    }
}
