using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Rectangle : IShape
    {
        public int Lenght { get; set; }
        public int Width { get; set; }
       
        public void getArea()
        {
            Console.WriteLine($"{Lenght * Width}");
        }
        public Rectangle(int length, int width)
        {
            Lenght = length;
            Width = width;
        }
    }
}
