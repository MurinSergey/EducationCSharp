using System;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class ResDelivery : Delivery
{
    /// <summary>
    /// ������ ��������� ����������
    /// </summary>
    private List<string> _resAddress;
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
            ConsoleUtils.WriteLine($"���������� �������� �������� ��� ��������� ������ ��� ���������� �����:");
            for (int i = 0; i < _resAddress.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_resAddress[i]}");
            }
            if (ConsoleUtils.ReadLine("�����: ") is string indexString && !string.IsNullOrWhiteSpace(indexString) && int.TryParse(indexString, out int index) && index > 0 && index <= _resAddress.Count)
            {
                try
                {

                    Address = _resAddress[index - 1];
                    ConsoleUtils.WriteLine($"�������, �������� ����� � ��������: {Address}");
                    break;
                }
                catch (ArgumentException err)
                {
                    ConsoleUtils.WriteLine($"{err.Message}");
                }
            }
            else
            {
                ConsoleUtils.WriteLine($"�������, ��� ����� �� ������������ ��������.");
            }
        }
    }

    protected override void SetupDeliveryDateTime()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine($"���������� ������� �������� ���� � ����� ��������� ��������� � ������� \"dd-MM-yyyy HH-mm\":");
            try
            {
                DeliveryDateTimeString = ConsoleUtils.ReadLine("������ \"dd-MM-yyyy HH-mm\": ");
                ConsoleUtils.WriteLine($"�������, ��������� ������������� ��: {DeliveryDateTimeString}");
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
            ConsoleUtils.WriteLine($"���������� ������� ��� �����:");
            try
            {
                UserName = ConsoleUtils.ReadLine("��� �����: ");
                ConsoleUtils.WriteLine($"�������, ������ ����� ������������ ��: {UserName}");
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
        ConsoleUtils.WriteLine($"��������� ��������: {Address}");
        ConsoleUtils.WriteLine($"����� ���������: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"�����: {UserName}");
    }
}
