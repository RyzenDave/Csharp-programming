using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Students
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Email {  get; set; }
        public string Subject { get; set; }

        public Students(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }

        public void GetNotification(string msg)
        {
            Console.WriteLine($"Student name:{Name} Msg: {msg}");
        }

      
    }
}
