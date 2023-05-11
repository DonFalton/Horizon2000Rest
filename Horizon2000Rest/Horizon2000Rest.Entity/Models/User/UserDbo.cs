using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.User
{
    public class UserDbo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
        public bool Active { get; set; }

        //public List <RoleNum> Roles { get; set; }
    }
}
