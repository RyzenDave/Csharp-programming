using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models;
public class Car : Vehicle
{
    public override void Move() => Drive();
    public void Drive()
    {
        Console.WriteLine("Driving");
    }
    public override void DisplayInfo()
    {
      Console.WriteLine("I'm a car and I drive on 4 wheels :)");
    }
   
}
