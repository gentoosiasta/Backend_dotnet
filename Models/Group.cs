using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend_dotnet.Models;

namespace Backend_dotnet.Models
{
    public class Group
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Period")]
        public virtual SchoolPeriod? Period { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("SubjectID")]
        public virtual Subject? Subject { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("GroupID")]
        public virtual Group? GroupID { get; set; }

        [StringLength(1)]
        public string? Status { get; set; }

        public int Capacity { get; set; }
    }
}