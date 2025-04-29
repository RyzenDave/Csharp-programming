using Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public class Tester : Human , i_Tester
    {
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public int BugsFound { get; set; }

        public Tester(string fullName, int age, long phoneNumber, int bugsFound)
            : base(fullName, age, phoneNumber) // Assuming Human has a constructor with these parameters
        {
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {BugsFound}";
        }

        public int bugBountiesRewardMoney()
        {
            return 1200;
        }

        public string bugType()
        {
            return "Severe";
        }

        public bool FoundBug()
        {
            return true;
        }
    }
}
