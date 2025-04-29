using System;
using Exercise2.Classes;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continueInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter the dog's details.");

                string name = GetValidInput("Enter dog's name:");
                string race = GetValidInput("Enter dog's race:");
                string color = GetValidInput("Enter dog's color:");

                Dog dog = new Dog
                {
                    Name = name,
                    Race = race,
                    Color = color
                };

                Console.WriteLine("What activity would you like the dog to do? Type either: eat, play, chasetail.");
                string activity = GetValidInput("Enter activity:");

                switch (activity.Trim().ToLower())
                {
                    case "eat":
                        Console.WriteLine(dog.Eat());
                        break;
                    case "play":
                        Console.WriteLine(dog.Play());
                        break;
                    case "chasetail":
                        Console.WriteLine(dog.ChaseTail());
                        break;
                    default:
                        Console.WriteLine("Invalid activity selected.");
                        break;
                }

                Console.WriteLine("\nWould you like to continue? (Y/n):");
                continueInput = Console.ReadLine()?.Trim().ToLower();
            } while (continueInput == "y" || continueInput == "yes");
        }

        static string GetValidInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Please enter a non-empty value.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}
