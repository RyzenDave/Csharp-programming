using Class_03_hmwrk.Entities;

namespace Class_03_hmwrk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name to search:");
            string searchInput = Console.ReadLine();

            //Just calls da method 
            UserDatabase.Search(searchInput);
        }
    }
}
