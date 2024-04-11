using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Area
    {
        [Key]
        [StringLength(6)]
        public string? AreaID { get; set; }

        [StringLength(200)]
        public string? AreaDescription { get; set; }

        [StringLength(50)]
        public string? AreaChief { get; set; }

        [ForeignKey("RFC")]
        public virtual Staff? RFC { get; set; }
    }
}