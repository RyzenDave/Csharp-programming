using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 1 professor
            Teacher professor = new Teacher("Professor John", 50, "john@university.edu", "Math");

            // Create 3 students
            Students student1 = new Students("Alice", 20, "alice@student.edu", "Math");
            Students student2 = new Students("Bob", 21, "bob@student.edu", "Math");
            Students student3 = new Students("Charlie", 22, "charlie@student.edu", "Math");

            // Subscribe all students
            professor.Subscribe(student1);
            professor.Subscribe(student2);
            professor.Subscribe(student3);

            Console.WriteLine();
            Console.WriteLine("Sending notifications....");
            professor.SendNotification("Class for Math will start at 10 AM.");
            Console.WriteLine();

            // Unsubscribe Alice and Charlie
            professor.Unsubscribe(student1);
            professor.Unsubscribe(student3);

            Console.WriteLine();
            Console.WriteLine("Sending notifications....");
            professor.SendNotification("Class for Math will start at 10 AM.");
        }
    }
}
