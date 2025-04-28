using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>
            {
                new Contractor("John", "Doe", 3000, 160, 20, null),
                new Contractor("Jane", "Smith", 3200, 160, 20, null),
                new Manager("Alice", "Johnson", "HR", 12200),
                new Manager("Bob", "Brown", "IT", 12200),
                new SalesPerson("Charlie", "Davis", 17000, 4000),
            };
        private double SharesPrice { get; set; }
        public int Shares { get; set; }

        public CEO(string firstName, string lastName, double salary)
            : base(firstName, lastName, salary)
        {
        }

        public void AddSharesPrice()
        {
            Console.Write("Enter new shares price: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double newPrice))
            {
                SharesPrice = newPrice;
                Console.WriteLine($"SharesPrice updated to {SharesPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. SharesPrice not updated.");
            }
        }

        public void PrintEmployees()
        {
            if (Employees == null || Employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                employee.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"the CEO of ArrowHead Studios:Firstname:{FirstName},Lastname:{LastName} with a salary of\n{Salary}");
        }
    }
}
