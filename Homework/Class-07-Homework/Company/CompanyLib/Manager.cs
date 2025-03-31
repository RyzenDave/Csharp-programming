using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Manager : Employee
    {
     private double Bonus { get; set; }

     public string Department { get; set; }

        public Manager(string firstName, string lastName, string department,double salary = 500)
             : base(firstName, lastName, salary)
        {
            Department = department;
        }
        public void AddBonus()
        {
            Console.WriteLine("Enter bonus amount:");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double bonus))
            {
                Bonus = bonus;
                Console.WriteLine($"Bonus set to: {bonus}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
       
    }
}
