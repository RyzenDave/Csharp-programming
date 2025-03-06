namespace ToString
{
    internal class CustomType
    {
        public int Value { get; set; }

        public override string ToString()
        {
            return $"Custom Value: {Value}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int someNumber = 234223;
            bool isTrue = false;
            DateTime now = DateTime.Now;
            CustomType customObj = new CustomType { Value = someNumber };

            // Converting types to string
            string numberString = someNumber.ToString();
            string isTrueString = isTrue.ToString();
            string dateString = now.ToString("F");  // Full date/time pattern
            string customString = customObj.ToString();

            Console.WriteLine("Number: " + numberString);
            Console.WriteLine("Boolean: " + isTrueString);
            Console.WriteLine("Date: " + dateString);
            Console.WriteLine("Custom Object: " + customString);

            Console.ReadLine();
        }
    }
}
