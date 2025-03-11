using ClassesnObjects.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassesnObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new user instance with initial property values
            User user1 = new()
            {
                UserName = "Alice",
                Password = "secret123"
            };

            // Utilize the User object by displaying its information
            user1.DisplayInfo();

            // Wait for user input so the console doesn't close immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Person bob = new Person();
            bob.firstName = "Bob";
            bob.lastName = "Smith";
            bob.Age = 30;
            // bob.SSN = 213094134; Class Parameter is Privated and unaccessable
            bob.DisplayInfo();
        }
    }
}




