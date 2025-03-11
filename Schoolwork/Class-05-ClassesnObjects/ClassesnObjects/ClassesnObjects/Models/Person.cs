using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesnObjects.Models
{
    public class Person
    {
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public int Age { get; set; }
        private long SSN { get; set; }

        // Generates and returns a random 9-digit SSN.
        private long GenerateSSN()
        {
            Random random = new();
            return random.Next(100000000, 1000000000);
        }

        public void DisplayInfo()
        {
            // Assign SSN if not already generated.
            if (SSN == 0)
            {
                SSN = GenerateSSN();
            }
            Console.WriteLine($"Personal Details: Name - {firstName} {lastName}, Age - {Age}, SSN - {SSN}");
        }
    }
}
