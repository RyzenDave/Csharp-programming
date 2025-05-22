using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3a.Models
{
    public class Triangle : Shapes
    {
        // Properties for triangle sides and base/height
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double sideA, double sideB, double sideC, double @base, double height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Base = @base;
            Height = height;
        }
        // Calculate area (using base * height / 2)
        public override void CalculateArea()
        {
            double area = (Base * Height) / 2;
            Console.WriteLine($"Triangle Area: {area}");
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Invalid triangle sides!");
            }
        }

        // Calculate perimeter (sum of all sides)
        public override void CalculatePerimeter()
        {
            double perimeter = SideA + SideB + SideC;
            Console.WriteLine($"Triangle Perimeter: {perimeter}");
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Invalid triangle sides!");
            }
        }
      
    }
}
