using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseTopic
    {
        [Key, Column(Order = 0)]
        [ForeignKey("SubjectID")]
        public virtual Subject? Subject { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(2)]
        public string? Topic { get; set; }

        [Required]
        [StringLength(150)]
        public string? TopicName { get; set; }

        [StringLength(400)]
        public string? LearningObjectve { get; set; }
    }
}