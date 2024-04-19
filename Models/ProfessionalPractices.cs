using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class ProfessionalPractices
    {
        [Key]
        [ForeignKey("ControlNumber")]
        public virtual Student? Student { get; set; }

        [ForeignKey("Period")]
        public virtual SchoolPeriod? Period { get; set; }

        [Required]
        [StringLength(255)]
        public string? ProjectName { get; set; }

        [Required]
        public int NumberOfParticipants { get; set; } = 1;

        [Required]
        [ForeignKey("CompanyAgreementID")]
        public virtual CompanyAgreement? Company { get; set; }

        [StringLength(100)]
        public string? ExternalConsultant { get; set; }

        [StringLength(100)]
        public string? ExternalConsultantPosition { get; set; }

        [StringLength(5)]
        public string? ExternalConsultantTitleAbbreviation { get; set; }

        [Required]
        [ForeignKey("RFC")]
        public virtual Staff? InternalAdvisor { get; set; }

        public bool IsAccepted { get; set; }

        public bool PresentationLetterPrinted { get; set; } = false;

        [ForeignKey("RFC")]
        public virtual Staff? FirstReviewer { get; set; }

        [ForeignKey("RFC")]
        public virtual Staff? SecondReviewer { get; set; }

        [ForeignKey("RFC")]
        public virtual Staff? ThirdReviewer { get; set; }

        public bool IsAuthorizedByAdvisor { get; set; }
    }
}