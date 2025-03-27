using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{

        public class Manager : Employee
        {
            public Manager(string name, string position, double salary, string department)
                : base(name, position, salary)
            {
                Department = department;
            }

            public string Department { get; set; }
        }
   
}
