using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Core.Models.ParentCourse
{
    /// <summary>
    /// Data transfer object for updating an existing parent course.
    /// </summary>
    public class UpdateParentCourseDto
    {
        /// <summary>
        /// Gets or sets the ID of the parent course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the parent course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image data of the parent course.
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or sets the file type of the parent course image.
        /// </summary>
        public string FileType { get; set; }
    }
}
