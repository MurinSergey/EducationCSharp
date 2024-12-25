using System;

namespace Module_06.Quest_631;

public class Quest_631
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 6.3.1===");

        var department = GetCurrentDepartment();
        
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург") {
            Console.WriteLine($"У банка {department?.Company?.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге");
        }
    }

    static Department GetCurrentDepartment()
	{
		// logic
        var department = new Department();
        return department;
	}
}
