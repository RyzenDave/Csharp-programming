using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Contractor : Employee
    {
        
        // Constructor for Contractor. It passes parameters to the Employee base class.
        public Contractor(string name, int id, int workhours, int payperhour)
            : base(name, id, workhours, payperhour)
        {

            // Any additional initialization for Contractor can be done here.
        }
    }
}
