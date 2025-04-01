using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class SalesPerson : Employee
    {
        
        public Role SalesRep { get; private set; } = Role.SalesRep;
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName, string lastName, double successSaleRevenue, double salary = 500)
           : base(firstName, lastName, salary)
        {
            SuccessSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue()
        {
            Console.WriteLine("Input Success Revenue for SalesPerson this year:");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double revenue))
            {
                SuccessSaleRevenue = revenue;
                Console.WriteLine($"Success Sale Revenue updated to: {SuccessSaleRevenue}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        public override double GetSalary()
        {
            if (Salary <= 2000)
            {
                Salary += 500;
                return Salary;
            }
            else if (Salary > 2000 && Salary <= 5000)
            {
                Salary += 1000;
                return Salary;
            }
            else
            {
                Salary += 1500;
                return Salary;
            }
        }
    }
}
