using Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public abstract class Human : i_Human
    {
        public Human(string fullName, int age, long phoneNumber)
        {
            this.fullName = fullName;
            this.Age = age;
            this.phoneNumber = phoneNumber;
        }

        public string fullName { get; set; }
        public int Age { get; set; }
        public long phoneNumber { get; set; }
        public abstract string GetInfo();

        public void HumanGreet(string name)
        {
            Console.WriteLine($"Hello, {name}! My name is {fullName}.");
        }


        public string SayGoodbye(string name)
        {
            return $"Goodbye {name}";
        }
    }
}
