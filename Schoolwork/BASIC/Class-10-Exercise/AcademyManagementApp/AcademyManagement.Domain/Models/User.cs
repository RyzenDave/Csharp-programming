using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public WindowsBuiltInRole Role { get; set; }

        public User(string firstName, string lastName, int age, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
        }
        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

    }
}
