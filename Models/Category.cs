using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Category
    {
        [Key]
        [StringLength(6)]
        public string? CategoryID { get; set; }

        [Required]
        [StringLength(200)]
        public string? CategoryDescription { get; set; }

        public int CategoryHours { get; set; }

        public int HoursFrontGroup { get; set; }
    }
}