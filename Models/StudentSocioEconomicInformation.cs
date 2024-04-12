using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyNamespace.Models;

namespace Backend_dotnet.Models
{
    public class StudentSocioEconomicInformation
    {
        [Key]
        [ForeignKey("ControlNumber")]
        public virtual Student? ControlNumber { get; set; }

        [ForeignKey("SchoolLevelId")]
        public virtual SchoolLevel? FatherSchoolLevel { get; set; }

        [ForeignKey("SchoolLevelId")]
        public virtual SchoolLevel? MotherSchoolLevel { get; set; }

        public int HowManyDoYouLiveWith { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal FatherIncome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal MotherIncome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal BrothersIncome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OwnIncome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OtherIncome { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalIncome { get; set; }

        [ForeignKey("ParentJobID")]
        public virtual ParentJob? FatherJob { get; set; }

        [ForeignKey("ParentJobID")]
        public virtual ParentJob? MotherJob { get; set; }

        [ForeignKey("WhoStudentDependOnID")]
        public virtual WhoStudentDependOn? WhoStudentDependOn { get; set; }

        [ForeignKey("HomeMaterialID")]
        public virtual HomeMaterial? HomeMaterial { get; set; }
    }
}