using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BeamNGSkillz.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Driver Driver { get; set; }

        public static double CalculateSpeed(Driver driver, double carSpeed)
        {
            if (double.TryParse(driver.Skill, out double driverSkill))
            {
                return driverSkill * carSpeed;
            }
            else
            {
                throw new ArgumentException("Driver's Skill is not a valid number.");
            }
        }
    }
}
