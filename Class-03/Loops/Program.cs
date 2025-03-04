Console.WriteLine("===== Creating an Array =====");
// Array type syntax
//Array of integers: int[]
//Array of strings: string[]
//Array of doubles: double[]
//Array of characters: char[]

//1. Declaring and initializing an array
int[] numbers = new int[] { 11, 22, 1, 2, 33, -5, 3 };
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[4]);
//2. Declaring an array 
string[] students = new string[3];
students[0] = "John";
students[1] = "Doe";
students[2] = "Jane";
Console.WriteLine(students[0]);

Console.WriteLine("===== Array Methods =====");
Console.WriteLine("The numbers array lenght is" + numbers.Length);
// Sorting through an Array
Array.Sort(numbers);
Console.WriteLine(numbers[0]);
Console.ReadLine();

int indexOfOne = Array.IndexOf(numbers, 1);
Console.WriteLine($"The index of 1 is {indexOfOne}");
Console.WriteLine(numbers[indexOfOne]);

Console.WriteLine("===== Adding new items =====");
//Arrays have a fixed size so we cant directly add elements to them

string[] newStudents = new string[3];
newStudents[0] = "Bob";
newStudents[1] = "Joshua";
newStudents[2] = "Sam";
