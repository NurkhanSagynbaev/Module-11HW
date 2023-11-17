using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11HW
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DisplayAllEmployees()
        {
            foreach (var employee in employees)
            {
                employee.DisplayInfo();
            }
        }

        public void DisplayEmployeesByPosition(string position)
        {
            foreach (var employee in employees)
            {
                if (employee.Position == position)
                {
                    employee.DisplayInfo();
                }
            }
        }

        public void DisplayManagersAboveAverageClerkSalary()
        {
            decimal clerkAverageSalary = employees
                .Where(e => e.Position == "Clerk")
                .Average(e => e.Salary);

            var managers = employees
                .Where(e => e.Position == "Manager" && e.Salary > clerkAverageSalary)
                .OrderBy(e => e.LastName);

            foreach (var manager in managers)
            {
                manager.DisplayInfo();
            }
        }

        public void DisplayEmployeesHiredAfterDate(DateTime hireDate)
        {
            var filteredEmployees = employees
                .Where(e => e.HireDate > hireDate)
                .OrderBy(e => e.LastName);

            foreach (var employee in filteredEmployees)
            {
                employee.DisplayInfo();
            }
        }

        public void DisplayEmployeesByGender(char gender)
        {
            var filteredEmployees = employees
                .Where(e => gender == 'A' || e.Gender == gender)
                .OrderBy(e => e.LastName);

            foreach (var employee in filteredEmployees)
            {
                employee.DisplayInfo();
            }
        }
    }

}
