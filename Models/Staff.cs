using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Staff
    {
        [Key]
        [StringLength(13)]
        public string? RFC { get; set; }

        [ForeignKey("WorkCenterID")]
        public virtual WorkCenter? WorkCenter { get; set; }

        [ForeignKey("AreaID")]
        public virtual Area? Area { get; set; }

        [Required]
        [StringLength(18)]
        public string? CURP { get; set; }

        public int WorkerNumber { get; set; }

        [Required]
        [StringLength(45)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(35)]
        public string? Name { get; set; }

        public int DesignationHours { get; set; }

        [StringLength(1)]
        public string? Designation { get; set; }

        [StringLength(1)]
        public string? Class { get; set; }

        [StringLength(6)]
        public string? BranchEntry { get; set; }

        [StringLength(6)]
        public string? GovernmentEntry { get; set; }

        [StringLength(6)]
        public string? EducationEntry { get; set; }

        [StringLength(6)]
        public string? InstitutionEntry { get; set; }

        [StringLength(60)]
        public string? Address { get; set; }

        [StringLength(40)]
        public string? Suburb { get; set; }

        public int PostalCode { get; set; }

        [StringLength(30)]
        public string? Locality { get; set; }

        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [StringLength(1)]
        public string? Gender { get; set; }

        [StringLength(1)]
        public string? MaritalStatus { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? BirthDate { get; set; }

        [ForeignKey("EntidadFederativa")]
        public virtual FederalEntity? BirthPlace { get; set; }

        [StringLength(50)]
        public string? GraduationInstitution { get; set; }

        [ForeignKey("EducationalLevelID")]
        public virtual EducationalLevel? EducationalLevel { get; set; }

        [StringLength(1)]
        public string? MaxSchoolLevel { get; set; }

        [StringLength(250)]
        public string? Schooling { get; set; }

        [DataType(DataType.Date)]
        public DateOnly SchoolingEndDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly DegreeDate { get; set; }

        [StringLength(15)]
        public string? ProfessionalLicense { get; set; }

        [StringLength(50)]
        public string? Specialization { get; set; }

        [StringLength(60)]
        public string? LanguagesMastered { get; set; }

        [StringLength(2)]
        public string? Status { get; set; }

        public Byte[]? Picture { get; set; }

        public Byte[]? Sign { get; set; }

        [StringLength(60)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? FatherFullName { get; set; }

        [StringLength(50)]
        public string? MotherFullName { get; set; }

        [StringLength(50)]
        public string? SpouseFullName { get; set; }

        [StringLength(100)]
        public string? Children { get; set; }

        public int FolioNumber { get; set; }

        public int BookNumber { get; set; }

        public int SheetNumber { get; set; }

        public int Year { get; set; }

        [StringLength(15)]
        public string? MilitaryCard { get; set; }

        public int YearClass { get; set; }

        [ForeignKey("AreaID")]
        public virtual Area? AcademicArea { get; set; }
    }
}