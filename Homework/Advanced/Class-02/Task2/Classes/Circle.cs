using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Circle : IShape
    {
        public int Radius { get; set; }

       
        public Circle(int radius)
        {
            Radius = radius;
        }

        public void getArea()
        {
            Console.WriteLine($"{3.14 * Radius * 2}");
        }
    }
}

