using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public static class Calculator
    {
        public static double? LastResult { get; set; }
        public static string LastOperation { get;  set; }

        public static string Calculate()
        {
            Console.WriteLine("Enter first number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input.");
                LastResult = null;
                LastOperation = null;
                return "";
            }

            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input.");
                LastResult = null;
                LastOperation = null;
                return "";
            }

            double result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        LastResult = null;
                        LastOperation = null;
                        return "";
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    LastResult = null;
                    LastOperation = null;
                    return "";
            }

            LastResult = result;
            LastOperation = $"{num1}{op}{num2}={result}";
            Console.WriteLine($"Result: {LastOperation}");
            return LastOperation;
        }

        public static void PrintLastResultToFile(string filePath)
        {
            if (LastOperation != null)
            {
                File.AppendAllText(filePath, LastOperation + Environment.NewLine);
            }
        }
    }
}
