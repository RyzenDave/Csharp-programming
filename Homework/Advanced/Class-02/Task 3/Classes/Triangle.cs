using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Classes
{

    public class Triangle : Shapes
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double CalculateArea()
        {
            // Heron's formula
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
        public override void Display()
        {
            Console.WriteLine($"Triangle with sides {Side1}, {Side2}, {Side3}:");
            base.Display();
        }
    }
}
