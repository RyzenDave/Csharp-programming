int[] integers = new int[6];
int sum = 0;
Console.WriteLine("Please enter 6 integers");

for (int i = 0; i < integers.Length; i++)
{
    while (true)
    {
        Console.Write($"Enter integer {i + 1} of 6: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int parsedValue))
        {
            integers[i] = parsedValue;
            sum += parsedValue; // Add the parsed integer to the sum
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
}

Console.WriteLine($"The sum is: {sum}");
