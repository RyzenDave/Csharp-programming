using Task_4.Classes;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager boss = new Manager()
            {
                Name = "Alice",
                Id = 101,
                Bonus = 2000
            };
            
            Programmer dev = new Programmer()
            {
                Name = "Bob",
                Id = 102,
                LinesOfCodeWritten = 15000
            };

            // Use methods from the abstract class
            boss.DisplayInfo();
            boss.PrintCompanyPolicy(); // Inherited concrete method

            Console.WriteLine(); // Spacer

            dev.DisplayInfo();
            dev.PrintCompanyPolicy(); // Inherited concrete method
        }
    }
}
