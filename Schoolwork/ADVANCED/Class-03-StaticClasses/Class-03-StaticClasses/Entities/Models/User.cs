using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Class_03_StaticClasses.Entities.Models
{
    class User
    {
        public string UserName { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public List<Order> Orders { get; set; }

        public User(string userName, string address, int id)
        {
            UserName = userName;
            Address = address;
            Id = id;
         
        }
        
    }

}
