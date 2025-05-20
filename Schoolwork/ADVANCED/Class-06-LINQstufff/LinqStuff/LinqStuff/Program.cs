using System.Security.Cryptography;

namespace LinqStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum(int x, int y)
            {
                return x + y;
            }
            int Diff(int x, int y)
            {
                return x - y;
            } 
            int Mult(int x, int y)
            {
                return x * y;
            }
            #region Func
            //Func ALWAYS returns a value and is C# specific
            Func<int, int, int> sumOfTwo = (x, y) => x + y;
            Func<int, int, int> diffOfTwo = (x, y) => x - y;
            Func<int, int, int> multOfTwo = (x, y) => x * y;

            Func<int, int, bool> checkIfLarger = (x, y) =>
            {
                if (x > y)
                    return true;
                else
                    return false;
            };
            Console.WriteLine($"The sum of 5 and 10 is: {sumOfTwo(5,10)}");
            Console.WriteLine($"The diff of 10 and 4 is:{diffOfTwo(10,4)}");
            Console.WriteLine($"The product of 123 and 10 is:{multOfTwo(123,10)}");

            List<string> names = new() { "Martin", "John", "Paul", "George", "Ringo" };
            Func<List<string>, string> getFirstName = (list) =>
            {
                if (list.Count > 0)
                    return list[0];
                else
                    return "No names in the list";
            };
            #endregion
            #region Action
            //Action is a special delegate in C# and DOESNT return ANYTHING
            Action Hello = () =>
            {
                Console.WriteLine("Ello there! Im an action!");
            };
            Hello();
            Action<string> printInRed = (text) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ReadLine();
            };
            printInRed("This is a red text"); 
            
            Action<string, ConsoleColor> printInColor = (text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
                Console.ReadLine();
            };
            #endregion
            #region Higher Order Function use 
            //Higher Order Function
            //A function that takes a function as an argument or returns a function as a result
            string foundJohn = names.Find(x => x == "John");
            Console.WriteLine($"Found : {foundJohn}");
            #region Predicate Example
            // Predicate is a delegate that takes one input parameter and returns a boolean value
            Predicate<int> isEven = (x) => x % 2 == 0;

            List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using Predicate with Find method to find the first even number
            int firstEven = numbers.Find(isEven);
            Console.WriteLine($"The first even number is: {firstEven}");

            // Using Predicate inline with FindAll to get all even numbers
            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine("All even numbers:");
            evenNumbers.ForEach(Console.WriteLine);


            #endregion
        }
    }
}
