using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public Employee(string name, int id,int workhours, int payperhour)
        {
            Name = name;
            Id = id;
            WorkHours = workhours;
            PayPerHour = payperhour;
        }
    }

}
