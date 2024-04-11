using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Subject
    {
        [Key]
        [StringLength(7)]
        public string? SubjectID { get; set; }

        [Required]
        [ForeignKey("SchoolLevelID")]
        public virtual SchoolLevel? SchoolLevel { get; set; }

        public int SubjectType { get; set; }

        [ForeignKey("AreaID")]
        public virtual Area? Area { get; set; }

        [Required]
        [StringLength(100)]
        public string? SubjectFullName { get; set; }

        [Required]
        [StringLength(30)]
        public string? SubjectShortName { get; set; }
    }
}