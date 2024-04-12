using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class SocEc_HomeRoomsAndPeople
    {
        [Key]
        public int HomeRoomsAndPeopleID { get; set; }

        [Required]
        [StringLength(15)]
        public string? Description { get; set; }
    }
}