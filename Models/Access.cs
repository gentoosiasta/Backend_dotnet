using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Access
    {
        [Key]
        [StringLength(30)]
        public string? UserName { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [ForeignKey("RFC")]
        public virtual Staff? RFC { get; set; }

        [Required]
        [StringLength(100)]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        [StringLength(3)]
        public string? TypeOfUser { get; set; }

        [Required]
        [StringLength(1)]
        public string? Status { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}