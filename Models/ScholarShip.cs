using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class ScholarShip
    {
        [Key]
        [StringLength(5)]
        public string? ScholarShipID { get; set; }

        [Required]
        [StringLength(200)]
        public string? ScholarShipName { get; set; }

        [Required]
        public int Total { get; set; }

        [Required]
        public int Assigned { get; set; }
    }
}