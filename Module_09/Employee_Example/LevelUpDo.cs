using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Employee_Example;

internal class LevelUpDo
{
    internal static void Run()
    {
        List<Employee> employees = [
                new Employee() {Name = "Сергей"},
                new Employee(5.5, 20000) {Name = "Иван"},
                new Employee() {Name = "Роман"},
                new Employee(1.2, 12000) {Name = "Татьяна"}
            ];

        Predicate<Employee> checkLevelUp = (Employee employee) =>
        {
            if (employee.Experience - employee.LastExperience > 1)
            {
                return true;
            }
            return false;
        };

        for (int i = 0; i < 10; i++)
        {
            employees.ForEach(employee => employee.Do());
            Employee.LevelUp(employees, checkLevelUp);
        }

        
    }
}
