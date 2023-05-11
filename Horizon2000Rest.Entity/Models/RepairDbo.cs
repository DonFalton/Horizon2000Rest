using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Repair")]
    public class RepairDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public string Complaint { get; set; }

        public virtual ClientDbo Client { get; set; }

    }
}
