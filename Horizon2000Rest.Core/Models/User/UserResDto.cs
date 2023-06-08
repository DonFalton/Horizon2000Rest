using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Core.Models.User
{
    internal class UserResDto
    {
        public UserDetailsDto Userdetails { get; set; }
        //public List<RoleEnum> UserRoles { get; set; }
        public string Session { get; set; }

    }
}
