using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class StudentGeneralInformation
    {
        [Key]
        [ForeignKey("ControlNumber")]
        public virtual Student? ControlNumber { get; set; }

        [ForeignKey("FederalEntityID")]
        public virtual FederalEntity? BirthPlace { get; set; }
    }
}