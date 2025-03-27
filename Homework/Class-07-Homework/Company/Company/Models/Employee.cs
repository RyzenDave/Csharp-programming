using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company.Models
{
    public class Employee
    {
        public Employee(string name, string position, double salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} | Position: {Position} | Salary: {Salary}");
        }
    }
}
