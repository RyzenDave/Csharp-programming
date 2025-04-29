using Exercise.Entities;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract classes
            Developer dev = new Developer("Martin Panovski", 31, 0702312411, new List<string> { "C#", "JavaScript", "PhP" }, 7);
            Tester tester = new Tester("Bob Bobsky", 32, 0725236262, 100);

            Console.WriteLine($"Developer Info:");
            Console.WriteLine($"Name: {dev.fullName}");
            Console.WriteLine($"Age: {dev.Age}");
            Console.WriteLine($"Phone Number: {dev.phoneNumber}");
            Console.WriteLine($"Programming Languages: {string.Join(", ", dev.ProgrammingLanguages)}");
            Console.WriteLine($"Years of Experience: {dev.YearsOfExperience}");

            Console.WriteLine();

            Console.WriteLine($"Tester Info:");
            Console.WriteLine($"Name: {tester.FullName}");
            Console.WriteLine($"Age: {tester.Age}");
            Console.WriteLine($"Phone Number: {tester.PhoneNumber}");
            Console.WriteLine($"Bugs Found: {tester.BugsFound}");
            #endregion
        }
    }
   

}

 