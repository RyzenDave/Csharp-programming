using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    //CEO inherits FROM Employee
    public class CEO : Employee
    {
        // Properties specific to CEO
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public double SharesPrice { get; set; }

        // Constructor
        public CEO(string name, int id, int workhours, int payperhour, int shares, double sharesPrice)
            : base(name, id, workhours, payperhour) // Call base (Employee) constructor
        {
            Shares = shares;
            SharesPrice = sharesPrice;
            Employees = Array.Empty<Employee>(); // Initialize empty array
        }

        // Method to calculate total shares value
        public double CalculateTotalSharesValue()
        {
            return Shares * SharesPrice;
        }
    }
}