using System;
using System.Globalization;
using Module_07.Quest_Final.Utils;

namespace Module_07.Quest_Final.Delivery;

public class PickPointDelivery : Delivery
{
    /// <summary>
    /// ������ ���������� ������� ������
    /// </summary>
    private List<string> _pickPoints;
    /// <summary>
    /// �������� �������� ������, ������ � ����
    /// </summary>
    private int _storageInterval;
    /// <summary>
    /// ����� ��������� �������� ������
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
    /// ����� ��� ������ ������ ������
    /// </summary>
    protected override void SetupAddress()
    {
        while (true)
        {
            Console.WriteLine();
            ConsoleUtils.WriteLine("���������� �������� ����� ������ ������ ��� ���������� �����:");
            for (int i = 0; i < _pickPoints.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_pickPoints[i]}");
            }
            if (ConsoleUtils.ReadLine("�����: ") is string indexString && !string.IsNullOrWhiteSpace(indexString) && int.TryParse(indexString, out int index) && index > 0 && index <= _pickPoints.Count) 
            {
                try
                {
                    Address = _pickPoints[index - 1];
                    ConsoleUtils.WriteLine($"�������, �������� ����� ��������� �� ������ ������: {Address}");
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
    /// <summary>
    /// ����� ��� ������� ������� �������� � �������� ������
    /// </summary>
    protected override void SetupDeliveryDateTime()
    {
        DeliveryDateTime = DateTime.Today.Date.AddDays(1).AddHours(10);
        _endStorageDateTime = DeliveryDateTime.AddDays(_storageInterval);
        Console.WriteLine();
        ConsoleUtils.WriteLine($"�������� ����� ���������: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"����� ��������� {_storageInterval} ���� ��: {EndStorageDateTimeString}");
    }
    public override void PrintInfo()
    {
        Console.WriteLine();
        ConsoleUtils.WriteLine($"��� ������: {DeliveryType.ToRussinaString()}");
        ConsoleUtils.WriteLine($"��������� ����� ������: {Address}");
        ConsoleUtils.WriteLine($"����� ��������: {DeliveryDateTimeString}");
        ConsoleUtils.WriteLine($"����� �������� ��: {EndStorageDateTimeString}");
    }
}
