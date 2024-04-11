using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Student
    {
        [Key]
        [StringLength(10)]
        public string? ControlNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string? Career { get; set; }

        [Required]
        [StringLength(5)]
        public string? Speciality { get; set; }

        [Required]
        [StringLength(1)]
        public string? SchoolLevel { get; set; }

        [Required]
        public int Semester { get; set; }

        [StringLength(10)]
        public string? InternalKey { get; set; }

        [Required]
        [StringLength(3)]
        public string? Status { get; set; }

        [Required]
        [StringLength(1)]
        public string? Syllabus { get; set; }

        [Required]
        [StringLength(45)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(35)]
        public string? Name { get; set; }

        [StringLength(18)]
        public string? CURP { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [StringLength(1)]
        public string? Genero { get; set; }

        [StringLength(1)]
        public string? MaritalStatus { get; set; }

        [Required]
        public int IncomeType { get; set; }

        [Required]
        [StringLength(5)]
        public string? InstituteEntrancePeriod { get; set; }

        [Required]
        [StringLength(5)]
        public string? LastEnrolledPeriod { get; set; }

        public decimal AverageGradeOfLastPeriod { get; set; }

        public decimal AverageGrade { get; set; }

        public int ApprovedCredits { get; set; }

        public int CreditsTaken { get; set; }

        public decimal FinalAverageGrade { get; set; }

        [StringLength(1)]
        public string? TypeOfMedicalService { get; set; }

        [StringLength(20)]
        public string? MedicalServiceKey { get; set; }

        [Required]
        [StringLength(50)]
        public string? SchoolOfOrigin { get; set; }

        public int TypeOfSchool { get; set; }

        [StringLength(60)]
        public string? SchoolAddress { get; set; }

        [Required]
        [ForeignKey("FederalEntityID")]
        public virtual FederalEntity? EntityOfOrigin { get; set; }

        [Required]
        [StringLength(30)]
        public string? CityOfOrigin { get; set; }

        [StringLength(60)]
        public string? PersonalEmail { get; set; }

        public Byte[]? Picture { get; set; }

        public Byte[]? Sign { get; set; }

        public int RevalidatedPeriods { get; set; }

        public decimal CumulativeFailureRate { get; set; }

        [StringLength(100)]
        public string? ScolarshipFrom { get; set; }

        public int NIP { get; set; }

        [StringLength(2)]
        public string? TypeOfStudent { get; set; }

        [StringLength(3)]
        public string? Nationality { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}