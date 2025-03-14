using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Intrinsics.X86;

namespace Exercise2.Classes
{
    public class User
    {
        public User(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Messages = new string[] { }; // Initialize Messages to an empty array
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string[] Messages { get; set; }
    }
}
