using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_04_Generics.Models
{
    public class GenericListHelper<T>
    {
        public static void GoThroughItems(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
           
        }
        public static void GetInfoForItems(List<T> items)
        {
            T first = items.First();
            Console.WriteLine($"This list has {items.Count} items and is of type {first.GetType().Name}");
        }
    }   
}
