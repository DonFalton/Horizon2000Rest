namespace Horizon2000Rest.Core.Models.User
{
    /// <summary>
    /// Data transfer object for a user role.
    /// </summary>
    public class UserRoleDto
    {
        /// <summary>
        /// Gets or sets the ID of the user role.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the role.
        /// </summary>
        public int RoleID { get; set; }
    }
}
