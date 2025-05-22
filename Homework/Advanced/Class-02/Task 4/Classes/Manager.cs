using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4.Classes
{
    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public override decimal CalculateSalary()
        {
            return 5000 + Bonus; // Base salary AND bonus
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name} (ID: {Id})");
            Console.WriteLine($"Salary: ${CalculateSalary()}, Bonus: ${Bonus}");
        }
    }
}
