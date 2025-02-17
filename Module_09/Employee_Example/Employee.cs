using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Employee_Example;

class Employee
{
    private static int IDs = 1000;
    
    /// <summary>
    /// Свойство хранит ID сотрудника
    /// </summary>
    public int ID { get; private set; }

    /// <summary>
    /// Свойство хранит имя сотрудника
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Свойство хранит текущий опыт сотрудника
    /// </summary>
    public double Experience { get; private set; }

    /// <summary>
    /// Свойство хранит зафиксированный опыт сотрудника
    /// </summary>
    public double LastExperience { get; private set; }

    /// <summary>
    /// Свойство хранит зарплату сотрудника
    /// </summary>
    public int Salary { get; private set; }

    /// <summary>
    /// Конструктор создает нового сотрудника без опыта и бызовой запрлатой
    /// </summary>
    public Employee()
    {
        ID = IDs++;
        LastExperience = Experience = 0;
        Salary = 10000;
    }

    /// <summary>
    /// Конструктор создает нового сотрудника с опытом и с согласованной зарплатой
    /// </summary>
    /// <param name="experience"></param>
    /// <param name="salary"></param>
    public Employee(double experience, int salary)
    {
        ID = IDs++;
        LastExperience = Experience = experience;
        Salary = salary;
    }

    /// <summary>
    /// Метод добавляет опыта сотруднику при выполнении работы
    /// </summary>
    public void Do()
    {
        Experience += new Random().NextDouble();
    }

    /// <summary>
    /// Метод выполняет повышение сотрудника
    /// </summary>
    /// <param name="listEmployees"></param>
    /// <param name="checkExperience"></param>
    public static void LevelUp(List<Employee> listEmployees, Predicate<Employee> checkLevelUp)
    {
        foreach(Employee employee in listEmployees)
        {
            if (checkLevelUp(employee))
            {
                employee.LastExperience = employee.Experience;
                employee.Salary += 5000;
                Console.WriteLine("====================================");
                Console.WriteLine($"Сотрудник {employee.Name} был повышен.");
                Console.WriteLine($"Его новая зарлата: {employee.Salary}");
            }
        }
    }
}
