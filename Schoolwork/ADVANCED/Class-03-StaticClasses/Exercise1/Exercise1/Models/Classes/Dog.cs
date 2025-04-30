using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models.Classes
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void bark()
        {
            Console.WriteLine("Bark bark");
        }
        public static void Validate()
        {
    
            if (Id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Id), "Id cannot be less than 0");
            }

            if (Name == null || Name.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters long", nameof(Name));
            }
        }
    }
 
}
