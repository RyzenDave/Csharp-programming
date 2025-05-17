using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03_hmwrk.Entities
{

    public static class UserDatabase 
    {
        public static List<User> Users { get; } = new List<User>
        {
                    new User { Id = 1, Name = "Alice Johnson", Age = 28 },
                    new User { Id = 2, Name = "Bob Smith", Age = 34 },
                    new User { Id = 3, Name = "Charlie Lee", Age = 22 },
                    new User { Id = 4, Name = "Diana King", Age = 30 },
                    new User { Id = 5, Name = "Ethan Brown", Age = 25 },
                    new User { Id = 6, Name = "Fiona Clark", Age = 27 },
                    new User { Id = 7, Name = "George Miller", Age = 31 }
        };
    
        public static void Search(string searchTerm)
        {
            var results = Users
                .Where(u => u.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No users found with that name.");
            }
            else
            {
                foreach (var user in results)
                {
                    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
                }
            }
        }
    }
}
