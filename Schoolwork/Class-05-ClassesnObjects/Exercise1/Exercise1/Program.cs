using Exercise1.Classes;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human bobby = new Human();

            Console.WriteLine("Enter your first name please:");
            string firstName;
            while (string.IsNullOrWhiteSpace(firstName = Console.ReadLine()))
            {
                Console.WriteLine("First name is required. Please enter your first name:");
            }
            bobby.FirstName = firstName;

            Console.WriteLine("Enter your last name please:");
            string lastName;
            while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
            {
                Console.WriteLine("Last name is required. Please enter your last name:");
            }
            bobby.LastName = lastName;

            Console.WriteLine("Enter your age please:");
            int age;
            while (true)
            {
                string ageInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ageInput) && int.TryParse(ageInput, out age) && age > 0)
                    break;
                Console.WriteLine("A valid age is required. Please enter your age:");
            }
            bobby.Age = age;

            Console.WriteLine("Person Stats:");
            Console.WriteLine(bobby.GetPersonStats());
        }
    }
}
