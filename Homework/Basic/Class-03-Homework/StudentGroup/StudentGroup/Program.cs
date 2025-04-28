string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "David", "Darko", "Mario", "Angel", "Bleron" };

while (true)
{
    // Pick a group mate
    Console.Write("Choose a group! (G1/G2):");
    string groupChoice = Console.ReadLine()!.Trim().ToUpper();

    // Display the students of the chosen group
    if (groupChoice == "G1")
    {
        Console.WriteLine("Students of G1:");
        foreach (var student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (groupChoice == "G2")
    {
        Console.WriteLine("Students of G2:");
        foreach (var student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("Invalid group choice!");
    }

    // Ask if the user wants to continue
    Console.Write("Do you want to choose another group? (yes/no): ");
    string continueChoice = Console.ReadLine()!.Trim().ToLower();
    if (continueChoice != "yes")
    {
        break;
    }
}