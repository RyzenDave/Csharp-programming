using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models;

public class Boat : Vehicle
{
    public override void Move() => Sail();

    public void Sail()
    {
        Console.WriteLine("Sailing");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine("I'm a boat and I do not have wheels :(");
    }
}
