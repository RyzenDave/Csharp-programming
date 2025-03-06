// Get first number (with validation)
Console.Write("Enter first number: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Not a valid number!");
    return; // Exit early if input is invalid
}

// Get operator
Console.Write("Enter operator (+, -, *, /): ");
string op = Console.ReadLine();

// Get second number (with validation)
Console.Write("Enter second number: ");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Not a valid number!");
    return;
}

// Branching: Perform calculation based on operator
double result = 0;
bool isValidOperator = true;

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
        // Handle division by zero
        if (num2 != 0)
            result = num1 / num2;
        else
        {
            Console.WriteLine("Cannot divide by zero!");
            isValidOperator = false;
        }
        break;
    default:
        Console.WriteLine("Invalid operator!");
        isValidOperator = false;
        break;
}

// Display result only if everything was valid
if (isValidOperator)
    Console.WriteLine($"{num1} {op} {num2} = {result}");