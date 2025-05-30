using AdoNet.Services;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DAVIDNEWLAPTOP\\SQLEXPRESS;Database=SEDC_ACADEMY;Trusted_Connection=True;TrustServerCertificate=True;";
            StudentService studentService = new StudentService(connectionString);
            Console.WriteLine("Press 'ENTER' for all students from DB");
            Console.ReadLine();

            var students = studentService.GetAllStudents();

            foreach(var student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Id: {student.Id}, Date of Birth: {student.DateOfBirth:yyyy-MM-dd}");
            }
        }
    }
}
