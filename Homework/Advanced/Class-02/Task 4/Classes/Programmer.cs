using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Classes
{
    public class Programmer : Employee
    {
        public int LinesOfCodeWritten { get; set; }

        public override decimal CalculateSalary()
        {
            return 4000 + (LinesOfCodeWritten * 0.1m); // Base salary AND per-line bonus
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name} (ID: {Id})");
            Console.WriteLine($"Salary: ${CalculateSalary()}, Lines of code: {LinesOfCodeWritten}");
        }
    }
}
