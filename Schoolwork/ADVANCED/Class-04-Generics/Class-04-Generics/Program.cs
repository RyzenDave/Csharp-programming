using Class_04_Generics.Models;

namespace Class_04_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GENERIC HELPER IN ACTION ===");
            List<bool> booleans = new List<bool> { true, false };
            GenericListHelper<string>.GetInfoForItems(names);
            
        }
       
    }
}
