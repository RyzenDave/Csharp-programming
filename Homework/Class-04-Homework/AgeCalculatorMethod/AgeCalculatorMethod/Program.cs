namespace AgeCalculatorMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate;
            Console.WriteLine("Enter your birth date (MM/DD/YYYY):");

            // Loop until the user enters a valid date.
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Invalid date format. Please enter the date in MM/DD/YYYY format:");
            }

            int age = CalculateAge(birthDate);
            Console.WriteLine($"Calculated Age: {age}");
        }

        public static int CalculateAge(DateTime birthDate)
        {
            // Calculate the difference in years between today and the birthDate.
            int age = DateTime.Today.Year - birthDate.Year;

            // Adjust the age if the birthday hasn't occurred yet this year.
            if (birthDate > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
