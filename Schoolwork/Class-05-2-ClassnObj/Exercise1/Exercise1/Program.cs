using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    NumberStats(number);
                }
                else
                {
                    Console.WriteLine("That's not a valid number.");
                }

                Console.Write("Press Y to try again or X to exit: ");
                string choice = Console.ReadLine();
                
                if (choice.ToLower() != "y")
                {
                    continueLoop = false;
                }
                Console.WriteLine();

            }
        }

        static void NumberStats(double number)
        {
            // Check if the number is positive or negative
            string posNeg = number < 0 ? "negative" : "positive";

            // Check if the number is an integer
            bool isInteger = number % 1 == 0;

            // If an integer, determine if it is odd or even; otherwise skip odd/even test.
            string oddEven = "";
            if (isInteger)
            {
                // Casting to int is safe since we've confirmed there is no fractional part.
                oddEven = ((int)number % 2 == 0) ? "even" : "odd";
            }

            // Print the information
            Console.WriteLine($"The number {number} is {posNeg}.");

            if (isInteger)
            {
                Console.WriteLine($"It is an integer and it is {oddEven}.");
            }
            else
            {
                Console.WriteLine("It is a decimal (non-integer).");
            }
        }
    }
}
