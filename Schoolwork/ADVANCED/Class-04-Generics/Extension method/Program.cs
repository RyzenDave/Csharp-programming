using Extension_method.Helpers;

namespace Extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string VeryLongString = "this is a very long string for no reason because i need a long string";
            int oddNumber = 5;

            Console.WriteLine(VeryLongString.Shorten(3));
            Console.WriteLine(oddNumber.OddOrEven());
        }
    }
}
