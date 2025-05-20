using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Entities
{
    public class AirPlane : Vehicle
    {
       
            public override void DisplayInfo()
            {
                Console.WriteLine("I'm a plane and I have a couple of wheels :)");
            }
        
    }
}
