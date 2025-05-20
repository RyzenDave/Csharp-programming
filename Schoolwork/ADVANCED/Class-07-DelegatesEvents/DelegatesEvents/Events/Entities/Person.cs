using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Events.Entities
{
    public class Person
    {
        public string FullName { get; set; }
        public void WakeUp() => Console.WriteLine($"{FullName} wake up");
    }
}
