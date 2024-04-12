using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class RelativeType
    {
        [Key]
        public int RelativeID { get; set; }

        [Required]
        [StringLength(15)]
        public string? RelativeDescription { get; set; }
    }
}