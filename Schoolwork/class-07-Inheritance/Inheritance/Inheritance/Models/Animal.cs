using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Animal
    {

        public Animal(string name, string type, string color)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
        }
        
        
    
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public virtual void Speak()
        { Console.WriteLine($"{Name} says {Type} "); }

    }
}
