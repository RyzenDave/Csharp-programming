using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Triangle : IShape
    {
        public int sides { get; set; }

        public Triangle(int sides)
        {
            this.sides = sides;
        }

        public void getArea()
        {
            Console.WriteLine($"{sides * 3}");
        }
    }
}
