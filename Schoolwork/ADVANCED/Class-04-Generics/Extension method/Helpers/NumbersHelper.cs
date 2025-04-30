using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Extension_method.Helpers
{
    public static class NumbersHelper
    {
        public static string OddOrEven(this int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
