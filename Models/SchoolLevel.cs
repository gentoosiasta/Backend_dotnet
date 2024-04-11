using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class SchoolLevel
    {
        [Key]
        [StringLength(1)]
        public string? SchoolLevelID { get; set; }

        [Required]
        [StringLength(200)]
        public string? LevelDescription { get; set; }
    }
}