Console.WriteLine("Enter 4 numbers and get their average");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int result = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine($"The average is: {result}");