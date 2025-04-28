using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamNGSkillz.Classes
{
    class Driver
    {
        public string Name { get; set; }
        public string Skill { get; set; }

        public Driver(string name, string skill)
        {
            Name = name;
            Skill = skill;
        }

        public static double RaceCars(Car car1, Car car2)
        {
            double effectiveSpeed1 = Car.CalculateSpeed(car1.Driver, car1.Speed);
            double effectiveSpeed2 = Car.CalculateSpeed(car2.Driver, car2.Speed);



            

            Console.WriteLine($"{car1.Model} effective speed: {effectiveSpeed1}");
            Console.WriteLine($"{car2.Model} effective speed: {effectiveSpeed2}");
            if (effectiveSpeed1 > effectiveSpeed2)
            {
                Console.WriteLine($"{car1.Model} driven by: {car1.Driver.Name} wins the race!");
                return effectiveSpeed1;
            }
            else if (effectiveSpeed2 > effectiveSpeed1)
            {
                Console.WriteLine($"{car2.Model} driven by: {car2.Driver.Name} wins the race!");
                return effectiveSpeed2;
            }
            else
            {
                Console.WriteLine("The race is a tie!");
                return effectiveSpeed1; // Either one since they are equal
            }
            {
                Console.WriteLine("The race is a tie!");
                return effectiveSpeed1; // Either one since they are equal
            }
        }
    }

}