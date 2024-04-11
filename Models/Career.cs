using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Career
    {
        [Key]
        [StringLength(3)]
        public string? CareerID { get; set; }

        public int Sheet { get; set; }

        [ForeignKey("SchoolLevelID")]
        public virtual SchoolLevel? SchoolLevel { get; set; }

        [StringLength(20)]
        public string? OfficialKey { get; set; }

        [Required]
        [StringLength(80)]
        public string? CareerFullName { get; set; }

        [Required]
        [StringLength(30)]
        public string? CareerShortName { get; set; }

        [Required]
        [StringLength(10)]
        public string? Acronym { get; set; }

        public int MaxLoad { get; set; }

        public int MinLoad { get; set; }

        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        public int TotalCredits { get; set; }

        [StringLength(1)]
        public string? Modality { get; set; }

        [StringLength(1)]
        public string? Status { get; set; }
    }
}