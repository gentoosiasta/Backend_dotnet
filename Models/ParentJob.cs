using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class ParentJob
    {
        [Key]
        public int ParentJobID { get; set; }

        [Required]
        [StringLength(80)]
        public string? Job { get; set; }
    }
}