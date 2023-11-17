using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11HW
{
    class Program
    {
        static void Main()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            // Заполнение массива сотрудников
            // ...

            // Пример использования методов
            Console.WriteLine("All Employees:");
            employeeManager.DisplayAllEmployees();

            Console.WriteLine("Employees by Position:");
            employeeManager.DisplayEmployeesByPosition("Developer");

            Console.WriteLine("Managers above Average Clerk Salary:");
            employeeManager.DisplayManagersAboveAverageClerkSalary();

            // Другие методы могут быть использованы аналогичным образом
        }
    }

}
