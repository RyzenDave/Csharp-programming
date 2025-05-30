using AdoNet.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Services
{
    public class StudentService
    {
        private readonly string _connString;
        public StudentService(string connString)
        {
            _connString = connString;
        }
        public List<Student> GetAllStudents()
        {
            //1 open conn to data
            //2 create query
            //3 create query command
            //4 exec query command
            //5 read theh student data returned if there even is any 
            //6 map the data into list of students 
            //7 return the list of students
            var students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                string query = "SELECT ID, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber FROM Student";
                using (SqlCommand command = new SqlCommand(query,connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                            EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                            Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                            NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                            StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                        });
                    }
                }    
            }
            return students;
        }
    }
}
