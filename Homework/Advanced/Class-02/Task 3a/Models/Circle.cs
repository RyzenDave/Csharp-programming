using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3a.Models
{
    public class Circle : Shapes
    {
        public double Radius { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Math.PI * Radius * Radius}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter (Circumference): {2 * Math.PI * Radius}");
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
