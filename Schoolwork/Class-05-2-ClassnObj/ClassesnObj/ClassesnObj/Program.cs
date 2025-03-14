using ClassesnObj.Classes;
using System.Xml.Linq;

namespace ClassesnObj
{
    internal class Program
{
    static void Main(string[] args)
    {
        // Create an Academy
        Academy academy = new Academy("Qinshift Academy");

        // Create a Group within the Academy
        Group group = new Group("Group A", 30, "Room 101", academy);

        // Create a Student and assign the Group
        Student student = new Student("John Doe", 20)
        {
            Group = group
        };

        // Output the student's academy and classroom information
        Console.WriteLine($"Student: {student.FullName}");
        Console.WriteLine($"Academy: {student.Group.Academy.Name}");
        Console.WriteLine($"Group: {student.Group.Name}");
        Console.WriteLine($"ClassRoom: {student.Group.ClassRoomName}");
    }
}
}
