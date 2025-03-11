using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesnObjects.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        // Method to display user information
        public void DisplayInfo()
        {
            Console.WriteLine($"User Details: Name - {UserName}, Password - {Password}");
        }
    }
}