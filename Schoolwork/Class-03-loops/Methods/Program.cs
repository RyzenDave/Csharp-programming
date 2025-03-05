using System;

internal class Program
{
    private static void Main()
    {
        // Ask questions using methods
        string fullName = AskForFullName();
        int age = AskForAge();
        string race = AskForRace();
        string emotion = AskForEmotion();

        // Show summary
        DisplaySummary(fullName, age, race, emotion);
        Console.ReadLine(); // Keep console open
    }

    private static string AskForFullName()
    {
        Console.Write("What is your full name? ");
        return Console.ReadLine();
    }

    private static int AskForAge()
    {
        Console.Write("How old are you? ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static string AskForRace()
    {
        Console.Write("What is your race/ethnicity? ");
        return Console.ReadLine();
    }

    private static string AskForEmotion()
    {
        Console.Write("How are you feeling today? ");
        return Console.ReadLine();
    }

    private static void DisplaySummary(string name, int age, string race, string emotion)
    {
        Console.WriteLine("\n===== YOUR PROFILE =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Race/Ethnicity: {race}");
        Console.WriteLine($"Current Emotion: {emotion}");
    }
}