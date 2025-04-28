// Helper method to safely read an integer from the console
int ReadInt(string prompt)
{
    int value;
    while (true)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (int.TryParse(input, out value))
        {
            return value;
        }
        else
        {
            Console.WriteLine("Invalid input; please enter a valid integer.");
        }
    }
}

// Get user inputs for four numbers using TryParse validation
int num1 = ReadInt("Enter the First number: ");
int num2 = ReadInt("Enter the Second number: ");
int num3 = ReadInt("Enter the Third number: ");
int num4 = ReadInt("Enter the Fourth number: ");

// Calculating the sum and integer values
int sum = num1 + num2 + num3 + num4;
int average = sum / 4;

// End Result
Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");
