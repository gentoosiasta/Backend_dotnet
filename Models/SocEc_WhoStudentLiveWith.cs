using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class SocEc_WhoStudentLiveWith
    {
        [Key]
        public int WhoStudentLiveWithID { get; set; }

        [Required]
        [StringLength(30)]
        public string? Description { get; set; }
    }
}