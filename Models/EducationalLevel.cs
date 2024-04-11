using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class EducationalLevel
    {
        [Key]
        [StringLength(1)]
        public string? EducationalLevelID { get; set; }

        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
    }
}