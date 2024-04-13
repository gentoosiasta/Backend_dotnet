using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseOfficialProgram
    {
        [Key]
        [ForeignKey("SubjectID")]
        public virtual Subject? Subject { get; set; }

        [Required]
        [StringLength(450)]
        public string? SubjectObjective { get; set; }

        [Required]
        public int NumberOfTopics { get; set; }
    }
}