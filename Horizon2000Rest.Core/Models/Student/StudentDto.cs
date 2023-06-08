namespace Horizon2000Rest.Core.Models.Student
{
    /// <summary>
    /// Data transfer object for a student.
    /// </summary>
    public class StudentDto
    {
        /// <summary>
        /// Gets or sets the ID card of the student.
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// Gets or sets the title of the student.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the student.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the first address line of the student.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second address line of the student.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city of the student.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the postcode of the student.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the email of the student.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact number of the student.
        /// </summary>
        public string ContactNo { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the student.
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the ID of the student.
        /// </summary>
        public int ID { get; set; }
    }
}
