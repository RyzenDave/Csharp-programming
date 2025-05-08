using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;

namespace TaxiManager.Domain.Models
{
    public class User : BaseEntity
    {
        public User() 
        {
        }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public override string Print()
        {
            return $"Id: {Id}, Username: {Username}, Password: {Password}, Role: {Role}";
        }
    }
}
