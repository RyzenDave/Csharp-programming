using BeamNGSkillz.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample car instances with driver details.
            Car car1 = new Car
            {
                Model = "SportsCar",
                Speed = 100,
                Driver = new Driver { Name = "Alice", Skill = "1.5" }
            };
            Car car2 = new Car
            {
                Model = "SuperCar",
                Speed = 90,
                Driver = new Driver { Name = "Bob", Skill = "1.8" }
            };

            RaceCars(car1, car2);
        }

        static void RaceCars(Car car1, Car car2)
        {
            try
            {
                double calculatedSpeed1 = car1.CalculateSpeed(car1.Driver);
                double calculatedSpeed2 = car2.CalculateSpeed(car2.Driver);

                Console.WriteLine($"{car1.Model} effective speed: {calculatedSpeed1}");
                Console.WriteLine($"{car2.Model} effective speed: {calculatedSpeed2}");

                if (calculatedSpeed1 > calculatedSpeed2)
                {
                    Console.WriteLine($"{car1.Model} wins the race!");
                }
                else if (calculatedSpeed2 > calculatedSpeed1)
                {
                    Console.WriteLine($"{car2.Model} wins the race!");
                }
                else
                {
                    Console.WriteLine("The race is a tie!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during race: {ex.Message}");
            }
        }
    }
}
