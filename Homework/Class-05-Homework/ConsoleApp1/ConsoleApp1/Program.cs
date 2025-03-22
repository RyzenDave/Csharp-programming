using BeamNGSkillz.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predefined list of available car options without assigned drivers.
            List<Car> availableCars = new List<Car>
                {
                    new Car { Model = "Hyundai", Speed = 90 },
                    new Car { Model = "Mazda", Speed = 120 },
                    new Car { Model = "Ferrari", Speed = 170 },
                    new Car { Model = "Porsche", Speed = 190 }
                };

            // Predefined list of available driver options.
            List<Driver> availableDrivers = new List<Driver>
                {
                    new Driver("Bob", "1"),
                    new Driver("Greg", "2"),
                    new Driver("Jill", "3"),
                    new Driver("Anne", "4")
                };
            // All in a while loop
            while (true)
            {
                Console.WriteLine("Select a car for the first racer:");
                Car firstCar = ChooseCar(availableCars);
                Console.WriteLine($"\nYou selected: {firstCar.Model}");

                Console.WriteLine("\nSelect a driver for the first car:");
                Driver firstDriver = ChooseDriver(availableDrivers);
                Console.WriteLine($"\nYou selected: {firstDriver.Name}");
                firstCar.Driver = firstDriver;

                Console.WriteLine("\nSelect a car for the second racer:");
                Car secondCar = ChooseCar(availableCars);
                Console.WriteLine($"\nYou selected: {secondCar.Model}");

                Console.WriteLine("\nSelect a driver for the second car:");
                Driver secondDriver = ChooseDriver(availableDrivers);
                Console.WriteLine($"\nYou selected: {secondDriver.Name}");
                secondCar.Driver = secondDriver;

                // Start the race.
                Driver.RaceCars(firstCar, secondCar);

                Console.Write("\nDo you want to race again? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input != "y")
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        static Car ChooseCar(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model} (Speed: {cars[i].Speed})");
            }

            int selection = 0;
            while (true)
            {
                Console.Write("Enter option number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out selection) && selection >= 1 && selection <= cars.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }

            return cars[selection - 1];
        }

        static Driver ChooseDriver(List<Driver> drivers)
        {
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name} (Skill: {drivers[i].Skill})");
            }

            int selection = 0;
            while (true)
            {
                Console.Write("Enter option number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out selection) && selection >= 1 && selection <= drivers.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }

            return drivers[selection - 1];
        }
    }
}
