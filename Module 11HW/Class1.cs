using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11HW
{
 
    public interface IEmployeeInfo
    {
        void DisplayInfo();
    }

    public struct Employee : IEmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Hire Date: {HireDate}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine();
        }
    }

}
