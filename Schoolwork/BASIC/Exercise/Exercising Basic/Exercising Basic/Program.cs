namespace Exercising_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimmie 2 numbers");  

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input for the first number.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input for the second number.");
                return;
            }

            Console.WriteLine("Choose an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result;
            switch (operation)
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
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"The result is: {result}");
        }
    }
}
