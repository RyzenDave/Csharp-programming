// Get user inputs
Console.Write("Enter the First number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine()!.Trim();

// Perform calculation
double result = operation switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    "/" => num1 / num2,
    _ => throw new InvalidOperationException("Invalid operator entered!")
};

// Display result
Console.WriteLine($"The result is: {result}");