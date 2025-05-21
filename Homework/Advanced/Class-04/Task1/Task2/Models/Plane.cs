using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models;

public class AirPlane : Vehicle
{
    public override void Move() => Fly();

    public void Fly()
    {
        Console.WriteLine("Flying");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine("I'm a plane and I have a couple of wheels :)");
    }
}
