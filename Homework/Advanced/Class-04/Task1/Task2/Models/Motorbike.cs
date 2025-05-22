using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models;

    public class Motorbike : Vehicle
    {
    public override void Move() => Wheelie();
    public void Wheelie()
    {
        Console.WriteLine("Driving on one wheel");
    }
    public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
      
    }

