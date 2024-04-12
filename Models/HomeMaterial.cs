using System.ComponentModel.DataAnnotations;

namespace MyNamespace.Models
{
    public class HomeMaterial
    {
        [Key]
        [StringLength(1)]
        public string? HomeMaterialID { get; set; }

        [Required]
        [StringLength(80)]
        public string? Decription { get; set; }
    }
}