using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CompanyAgreement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyAgreementID { get; set; }

        [Required]
        [StringLength(100)]
        public string? CompanyName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LegalRepresentativeName { get; set; }

        [Required]
        [StringLength(255)]
        public string? CompanyAddress { get; set; }

        [Required]
        [ForeignKey("FederalEntityID")]
        public virtual FederalEntity? FederalEntity { get; set; }

        [Required]
        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? Suburb { get; set; }

        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Required]
        [StringLength(13)]
        public string? RFC { get; set; }

        [StringLength(100)]
        public string? BusinessLine { get; set; }

        [Required]
        [StringLength(100)]
        public string? EmailAddress { get; set; }

        [Required]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [StringLength(4)]
        public string? PhoneExtension { get; set; }

        [StringLength(100)]
        public string? WebSite { get; set; }
    }
}