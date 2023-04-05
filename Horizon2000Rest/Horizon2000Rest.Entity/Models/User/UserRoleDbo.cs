using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.User
{
    public class UserRoleDbo
    {

		public int ID { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }
    }
}
