using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseDidacticInstrumentation
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Period")]
        public virtual SchoolPeriod? Period { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("GroupID")]
        public virtual Group? Group { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("SubjectID")]
        public virtual Subject? Subject { get; set; }

        [Key, Column(Order = 3)]
        [ForeignKey("RFC")]
        public virtual Staff? Staff { get; set; }

        [Key, Column(Order = 4)]
        public int Topic { get; set; }

        [Key, Column(Order = 5)]
        public int Consecutive { get; set; }

        [Required]
        [StringLength(250)]
        public string? TeacherActivity { get; set; }

        [Required]
        [StringLength(250)]
        public string? StudentActivity { get; set; }

        [Required]
        [StringLength(250)]
        public string? ProductOfLearning { get; set; }
    }
}