using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class FederalEntity
    {
        [Key]
        public int FederalEntityID { get; set; }

        [Required]
        [StringLength(50)]
        public string? EntityName { get; set; }

        [Required]
        [StringLength(2)]
        public string? EntityKey { get; set; }
    }
}