using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03_StaticClasses.Entities.Helpers
{
    public class ConsoleHelper
    {
        public void WriteInColor(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
    }
}
