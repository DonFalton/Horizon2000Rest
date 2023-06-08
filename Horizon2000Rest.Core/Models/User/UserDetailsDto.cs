using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Core.Models.User
{
    internal class UserDetailsDto
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the user.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string Email { get; set; }
    }
}
