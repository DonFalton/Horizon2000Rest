using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Core.Models.User
{
    public class UserLoginDto
    {
        /// <summary>
        /// Gets or sets the status of the user login.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the message associated with the user login status.
        /// </summary>
        public string Message { get; set; }
    }
}
