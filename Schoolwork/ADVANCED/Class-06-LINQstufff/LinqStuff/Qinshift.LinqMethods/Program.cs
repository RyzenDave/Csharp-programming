using System.Dynamic;
using System.Formats.Tar;
using System.Security.Cryptography;
using LinqStuff.Qinshift.LinqMethods.Entities;


namespace Qinshift.LinqMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHERE
            //SQL LIKE SYNTAX
            var findBobSQL = from std in Database.Students
                             where std.FirstName == "Bob"
                             where std.FirstName.Contains("Bob")
                             select std;
            Console.WriteLine($"Found student: {findBobSQL.FirstOrDefault()?.FirstName} {findBobSQL.FirstOrDefault()?.LastName} {findBobSQL.FirstOrDefault()?.Age}");
            //LINQ SYNTAX
            IEnumerable<Student> findBobLINQ = Database.Students
                .Where(std => std.FirstName == "Bob")
                .Where(std => std.FirstName.Contains("Bob"));
            findBobSQL.ToList().PrintEntities();
            findBobLINQ.ToList().PrintEntities();
            //SELECT 
            Console.WriteLine("==== SELECT ====");
            List<string> firstNamesSql = (from std in Database.Students
                                         select std.FirstName).ToList();
            List<string> fullNames = (from std in Database.Students
                                      select $"{std.FirstName} {std.LastName}").ToList();
            firstNamesSql.PrintSimple();
            fullNames.PrintSimple();
            //Lambda LINQ syntax 
            List<string> firstNamesLINQ = Database.Students
                .Select(std => std.FirstName)
                .ToList();
            Console.WriteLine("==== Complex Queries ====");
            List<Student> programmingStudentsSql = (from std in Database.Students
                                              where std.IsPartTime && std.Subjects is not null
                                              where std.Subjects.Any(sub => sub.Type == Academy.Programming)
                                              select std).ToList();
                                           
            programmingStudentsSql.PrintEntities();


            



        }
    }
}
