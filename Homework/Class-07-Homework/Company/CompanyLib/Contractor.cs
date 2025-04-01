using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLib
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager ResponsibleManager { get; set; }

        public Contractor(string firstName, string lastName, double salary, double workHours, int payPerHour, Manager responsibleManager)
            : base(firstName, lastName, salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            ResponsibleManager = responsibleManager;
        }
        public override double GetSalary()
        {
            WorkHours = 8;
            PayPerHour = 23;
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public string CurrentPosition()
        {
            return ResponsibleManager.Department;
        }
    }

}
    