string[] names = new string[0];

while (true)
{
    Console.WriteLine("Please enter a name to add to the array.");
    string name = Console.ReadLine();
    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = name;
    Console.WriteLine("The name has been added to the array.");
    Console.WriteLine("The names in the array are:");
    foreach (string n in names)
    {
        Console.WriteLine(n);
    }
    Console.WriteLine();

    Console.WriteLine("Do you want to enter another name? (Y/N)");
    string response = Console.ReadLine();
    if (response?.ToUpper() != "Y")
    {
        break;
    }
}
