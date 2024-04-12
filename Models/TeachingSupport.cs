using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class TeachingSupport
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Period")]
        public virtual SchoolPeriod? Period { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("RFC")]
        public virtual Staff? Staff { get; set; }

        [Key, Column(Order = 2)]
        public string? Activity { get; set; }

        [Required]
        public int Consecutive { get; set; }

        [StringLength(254)]
        public string? Description { get; set; }
    }
}