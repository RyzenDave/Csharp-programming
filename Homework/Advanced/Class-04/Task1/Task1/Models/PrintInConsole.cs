using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class PrintInConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Print(item);
            }
        }
    }
}
