using Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List Generic Collections
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);

            List<string> names = new List<string>() { "martin", "Frose", "darko" };
            names.Add("Amogus");
            Console.WriteLine("Printing names list:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numberz LOOK {numbers[i]}");
            }

            List<User> users = new List<User>
            {
                new() { FirstName = "Martin", LastName = "Martovski" },
                new() { FirstName = "Alice", LastName = "Anderson" },
                new() { FirstName = "Bob", LastName = "Brown" },
                new() { FirstName = "Charlie", LastName = "Clark" },
                new() { FirstName = "Diana", LastName = "Dawson" }
            };

            // --- List<User> Manipulations Examples ---

            // 1. Add a new user at the end
            users.Add(new User { FirstName = "Eve", LastName = "Evans" });

            // 2. Insert a user at a specific index
            users.Insert(1, new User { FirstName = "Frank", LastName = "Foster" });

            // 3. Iterate using foreach and print each user's info
            Console.WriteLine("\nIteration using foreach:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }

            // 4. Iterate using a for loop with index
            Console.WriteLine("\nIteration using for-loop:");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"Index {i}: {users[i].FirstName} {users[i].LastName}");
            }

            // 5. Access a specific element by index
            Console.WriteLine("\nAccessing user at index 2:");
            User specificUser = users[2];
            Console.WriteLine($"{specificUser.FirstName} {specificUser.LastName}");

            // 6. Search for a user by predicate (first name "Alice")
            User foundUser = users.Find(u => u.FirstName == "Alice");
            Console.WriteLine("\nFound user using Find method:");
            if (foundUser != null)
                Console.WriteLine($"{foundUser.FirstName} {foundUser.LastName}");

            // 7. Use LINQ to query list: get users whose first name starts with 'C'
            var usersStartingWithC = users.Where(u => u.FirstName.StartsWith("C")).ToList();
            Console.WriteLine("\nUsers with first name starting with 'C':");
            usersStartingWithC.ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName}"));

            // 8. Remove a user by object (remove Bob)
            User userToRemove = users.Find(u => u.FirstName == "Bob");
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                Console.WriteLine("\nRemoved user Bob");
            }

            // 9. Remove a user by index (remove first element)
            if (users.Count > 0)
            {
                users.RemoveAt(0);
                Console.WriteLine("\nRemoved user at index 0");
            }

            // 10. Remove all users with last name starting with 'C'
            int removedCount = users.RemoveAll(u => u.LastName.StartsWith("C"));
            Console.WriteLine($"\nRemoved {removedCount} users whose last name starts with 'C'");

            // 11. Sort users by first name
            users.Sort((u1, u2) => string.Compare(u1.FirstName, u2.FirstName));
            Console.WriteLine("\nSorted users by first name:");
            users.ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName}"));

            // 12. Check if any user with first name "Alice" exists
            bool containsAlice = users.Any(u => u.FirstName == "Alice");
            Console.WriteLine($"\nList contains user with first name 'Alice': {containsAlice}");

            // 13. Convert list to array and display length
            User[] usersArray = users.ToArray();
            Console.WriteLine($"\nConverted list to an array. Array length: {usersArray.Length}");

            // 14. Clear the list (Uncomment to test clear function)
            // users.Clear();
            // Console.WriteLine("\nCleared all users from the list");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
            #endregion
            #region Dictionary - Generic Collection
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                { 1, "Martin"},
                { 2, "Frose"},
                { 3,  "Viktor"},
            };


            PrintNames(students);

            #endregion

        }
        public static void PrintNames(Dictionary<int, string>students)
        {
            foreach( var student in students)
            {
                Console.WriteLine($"{student.Key}{student.Value}");
            }
        }

    }
    
    
}
