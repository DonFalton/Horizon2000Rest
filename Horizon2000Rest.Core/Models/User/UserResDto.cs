using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Core.Models.User
{
    internal class UserResDto
    {
        /// <summary>
        /// Gets or sets the user details.
        /// </summary>
        public UserDetailsDto UserDetails { get; set; }

        //public List<RoleEnum> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the session token.
        /// </summary>
        public string Session { get; set; }

    }
}
