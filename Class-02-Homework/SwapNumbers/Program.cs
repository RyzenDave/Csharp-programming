﻿
Console.Write("Input the First Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the Second Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());


double temp = num1;
num1 = num2;
num2 = temp;

// Display results
Console.WriteLine("After Swapping:");
Console.WriteLine($"First Number: {num1}");
Console.WriteLine($"Second Number: {num2}");