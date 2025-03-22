using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Dog : Animal
    {
        string Breed { get; set; }
        public Dog(string name, string type, string color, string breed) : base(name, type, color)
        {
            this.Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof");

        }

       
    }
}
