using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Classes
{
 
public abstract class Shapes
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    
    // Common method available to all shapes
    public virtual void Display()
    {
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}

}
