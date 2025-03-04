Console.WriteLine("===== Loops =====");
Console.WriteLine("===== For While Loop =====");
//Example of printing numbers from 1 to 10
/* 
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

int counter = 1;
while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

counter = 1;
while (counter <= 10)
{
    if (counter % 2 != 0)
    {
        Console.Write(counter + ",");
    }
    counter++;
}

Console.WriteLine();
Console.WriteLine("===== Do While =====");

//example:  Get valid number input
bool isValid;
do
{
    string? input = Console.ReadLine();
    isValid = int.TryParse(input, out int parsednumber);
    if (isValid)
    {
        Console.WriteLine($"The number is {parsednumber}");
    }
    else
    {
        Console.WriteLine("Invalid input, please try again");
    }
} while (!isValid);
*/
Console.WriteLine("===== Looping through an Array =====");
string[] students = new string[] { "John", "Doe", "Jane" };
for (int i = 0; i < students.Length; i++)
{
    Console.Write(students[i]);
}
Console.WriteLine("===== For Each =====");
foreach (string student in students)
{
    Console.Write(student);
}