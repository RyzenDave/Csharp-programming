using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamNGSkillz.Classes
{
    class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }
        
        public double CalculateSpeed(Driver driver)
        {
            if (double.TryParse(driver.Skill, out double driverSkill))
            {
                return driverSkill * Speed;
            }
            else
            {
                throw new ArgumentException("Driver's Skill is not a valid number.");
            }
        }
    }
}
