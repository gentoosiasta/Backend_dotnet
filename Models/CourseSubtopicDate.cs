using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseSubtopicDate
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
        public int Subtopic { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly ScheduledStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly ScheduledEndDate { get; set; }
    }
}