using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class SupportActivity
    {
        [Key]
        [StringLength(10)]
        public string? ActivityName { get; set; }

        [Required]
        [StringLength(200)]
        public string? ActivityDescription { get; set; }

        public List<string>? Goals { get; set; }
    }
}