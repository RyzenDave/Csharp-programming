using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Classes
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        // Abstract methods (must be implemented by child classes)
        public abstract decimal CalculateSalary();
        public abstract void DisplayInfo();

        // Concrete method (shared by all child classes)
        public void PrintCompanyPolicy()
        {
            Console.WriteLine("All employees must follow company policies.");
        }
    }
}
