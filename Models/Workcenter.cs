using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Workcenter
    {
        [Key]
        [StringLength(10)]
        public string? WorkcenterID { get; set; }

        [StringLength(1)]
        public string? EconomicZone { get; set; }

        [ForeignKey("FederalEntityID")]
        public virtual FederalEntity? FederalEntity { get; set; }

        [Required]
        [StringLength(2)]
        public string? WorkcenterKey { get; set; }

        [Required]
        [StringLength(50)]
        public string? WorkcenterName { get; set; }

        [StringLength(60)]
        public string? Address { get; set; }

        [StringLength(40)]
        public string? Suburb { get; set; }

        public int PostalCode { get; set; }

        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? FoundationDate { get; set; }
    }
}