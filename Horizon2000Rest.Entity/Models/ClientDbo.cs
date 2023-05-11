using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Client")]
    public class ClientDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public string HouseNumber { get; set; }

        public string HouseName { get; set; }

        public string Street { get; set; }

        public string Locality { get; set; }

        [Required]
        public string ContactNo { get; set; }

        public string VatNo { get; set; }

        public string Email { get; set; }

        public virtual ICollection<RepairDbo> Repairs { get; set; }

    }
}
