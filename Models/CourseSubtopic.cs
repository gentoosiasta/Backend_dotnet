using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseSubtopic
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Subject")]
        public virtual CourseTopic? Subject { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Topic")]
        public virtual CourseTopic? Topic { get; set; }

        [Key, Column(Order = 2)]
        [StringLength(15)]
        public string? Subtopic { get; set; }

        [Required]
        [StringLength(150)]
        public string? SubtopicName { get; set; }


    }
}