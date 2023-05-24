using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a scrolling text entity.
    /// </summary>
    [Table("ScrollingText")]
    public class ScrollingTextDbo
    {
        /// <summary>
        /// Gets or sets the ID of the scrolling text.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the text content of the scrolling text.
        /// </summary>
        [Required]
        public string ScrollText { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the scrolling text was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the scrolling text is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }
    }
}
