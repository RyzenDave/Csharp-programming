using System.Xml.Serialization;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
                {
                    { "Alice", "555-1234" },
                    { "Bob", "555-5232" },
                    { "David", "555-5642" },
                    { "Aidi", "555-8678" },
                    { "Rock", "555-5378" }
                };

            Console.WriteLine("Enter a person you'd like to get the number from: Alice, Bob, David, Aidi, and Rock");
            string userInput = Console.ReadLine() ?? "";

            DisplayPhoneNumber(phoneBook, userInput);
        }

        static void DisplayPhoneNumber(Dictionary<string, string> phoneBook, string userInput)
        {
            while (true)
            {
                string lowerUserInput = userInput.ToLower();

                // Find the matching phone book entry using ToLower on the keys
                string? foundKey = phoneBook.Keys.FirstOrDefault(name => name.ToLower() == lowerUserInput);

                if (foundKey != null)
                {
                    Console.WriteLine($"The phone number for {foundKey} is: {phoneBook[foundKey]}");
                }
                else
                {
                    Console.WriteLine("Name not found.");
                }

                Console.WriteLine("Would you like to find another number? (y/n)");
                string userChoice = Console.ReadLine() ?? "";
                if (!(userChoice.ToLower() == "y" || userChoice.ToLower() == "yes"))
                {
                    break;
                }

                Console.WriteLine("Enter a person you'd like to get the number from: Alice, Bob, David, Aidi, and Rock");
                userInput = Console.ReadLine() ?? "";
            }
        }
    }
}
