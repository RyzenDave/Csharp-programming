// Get user inputs for four numbers
Console.Write("Enter the First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Fourth number: ");
int num4 = Convert.TryParse(Console.ReadLine());

// Calculate sum and integer average
int sum = num1 + num2 + num3 + num4;
int average = sum / 4;

// Display result
Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {average}");