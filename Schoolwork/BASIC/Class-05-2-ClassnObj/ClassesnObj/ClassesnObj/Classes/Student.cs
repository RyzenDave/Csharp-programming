using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ClassesnObj.Classes
{
    public class Student
    {
        public Student(string? fName, int? age)
        {
            FullName = fName;
            Age = age;
        }

        public string? FullName { get; set; }
        public int? Age { get; set; }
        public Group? Group { get; set; }
    }
}


