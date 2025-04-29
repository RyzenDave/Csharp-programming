using Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public class Developer : Human, i_Developer
    {
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }

        public Developer(string fullName, int age, long phoneNumber, List<string> programmingLanguages, int yearsOfExperience)
            : base(fullName, age, phoneNumber) // Pass required parameters to the base class constructor
        {
            fullName = fullName;
            Age = age;
            phoneNumber = phoneNumber;
            ProgrammingLanguages = programmingLanguages;
            YearsOfExperience = yearsOfExperience;
        }

        // Implement the abstract method from the base class
        public override string GetInfo()
        {
            return $"{fullName}, Age: {Age}, Phone: {phoneNumber}, Languages: {string.Join(", ", ProgrammingLanguages)}, Experience: {YearsOfExperience} years";
        }

        public string Code()
        {
            return "nigga";
        }

        public string Debug()
        {
            return "WHY WONT MY CODE WORK FUCK FUCK FUCK FUCK FUCK";
        }

        public string SipCoffee()
        {
            return "SIPP";
        }

    }
}

