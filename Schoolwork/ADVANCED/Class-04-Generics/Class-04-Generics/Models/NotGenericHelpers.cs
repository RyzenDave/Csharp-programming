using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_04_Generics.Models
{
    public class NotGenericHelpers
    {
        public void GoThroughStrings(List<string> strings)
        {
            foreach(string str in strings)
            {
                Console.WriteLine(str);
            }
        }
        public void GetInfoForStrings(List<string> strings)
        {
            string first = strings.First();
            Console.WriteLine($"This list has {strings.Count} items and is of type  ");
        }
        public void GoThroughInts(List<int> ints)    
        {
            foreach(int num in ints)
            {
                Console.WriteLine(num);
            }    
            
        }
        public void GetInfoForInts(List<int> ints)
        {
            int first = ints.First(); // Gets the first integer
            Console.WriteLine($"This list has {ints.Count} items and is of type {first.GetType().Name}");
        }
    }
}
