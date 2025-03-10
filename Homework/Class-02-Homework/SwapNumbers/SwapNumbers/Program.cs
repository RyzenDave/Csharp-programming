using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            // Get and validate first number
            bool isValid;
            do
            {
                Console.Write("Input the First Number: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num1);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Please enter a whole number.");
                }
            } while (!isValid); 

            // Get and validate second number
            do
            {
                Console.Write("Input the Second Number: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num2);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Please enter a whole number.");
                }
            } while (!isValid);

            // Swapping logic
            int temp = num1;
            num1 = num2;
            num2 = temp;

            // Results
            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
        }
    }
}