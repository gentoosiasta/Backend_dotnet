using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class WhoStudentDependOn
    {
        [Key]
        public int WhoStudentDependOnID { get; set; }

        [Required]
        [StringLength(30)]
        public string? Description { get; set; }
    }

}