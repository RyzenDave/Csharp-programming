using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesnObj.Classes
{
    public class Group
    {
        public Group(string name, int numberOfStudents, string classRoomName, Academy academy)
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
            ClassRoomName = classRoomName;
            Academy = academy;
        }

        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
        public string ClassRoomName { get; set; }
        public Academy Academy { get; set; }
    }
}


