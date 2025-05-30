using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftClass10
{
    public class User
    {
        public User(string firstname, string lastName, int age)
        {
            FirstName = firstname;
            LastName = lastName;
            Age = age;
        }
        ~User() 
        {
            Console.WriteLine($"User {FirstName} {LastName} at time:{DateTime.Now} is being destroyed.");

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
         
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
