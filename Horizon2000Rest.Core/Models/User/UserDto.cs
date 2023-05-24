namespace Horizon2000Rest.Core.Models.User
{
    /// <summary>
    /// Data transfer object for a user.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        public int ID { get; set; }

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
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the date the user was registered.
        /// </summary>
        public DateTime DateRegistered { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is active.
        /// </summary>
        public bool Active { get; set; }

        //public List <RoleNum> Roles { get; set; }
    }
}
