using System;
using System.Collections.Generic;
using Exercise2.Classes;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User(1, "Alice", "password1")
                {
                    Messages = new string[] { "Welcome Alice", "Enjoy your stay" }
                },
                new User(2, "Bob", "password2")
                {
                    Messages = new string[] { "Hello Bob", "Have a great day" }
                },
                new User(3, "Charlie", "password3")
                {
                    Messages = new string[] { "Hi Charlie", "Good luck!" }
                }
            };

            Console.WriteLine("=== Registration ===");  
            Console.Write("Enter ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Console.Write("Enter username: ");
            string userName = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Check if a user with the same username already exists.
            User existingUser = users.Find(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));

            if (existingUser != null)
            {
                Console.WriteLine($"Error: There is already a user called {userName}.");
            }
            else
            {
                // Create and add the new user.
                User newUser = new User(id, userName, password)
                {
                    Messages = new string[] { } // Initialize messages to an empty array
                };
                users.Add(newUser);

                Console.WriteLine("Registration complete! Users:");
                foreach (User user in users)
                {
                    Console.WriteLine($"\t{user.Id} {user.UserName}");
                }
            }
        }
    }
}
