namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("===== String Formatting =====");
            //Currency formattings
            string currency = string.Format("price: {0:C}", 123.45);
            Console.WriteLine(currency);

            //Percentage formatting
            string percent = string.Format("percent {0:P0}", 0.5);
            Console.WriteLine(percent);

            //Custom formatting
            string customPhoneNumberFormat = string.Format("Phone number: {0:0##-###-###}", 053832308);
            Console.WriteLine(customPhoneNumberFormat);

            int number = 1234567;
            string CustomNumberFormat = string.Format("Number format {0:#,##0}", number);
            Console.WriteLine(CustomNumberFormat);



        }

    }
}
