using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class SchoolPeriod
    {
        [Key]
        [StringLength(5)]
        public string? Period { get; set; }

        [Required]
        [StringLength(30)]
        public string? LongIdentification { get; set; }

        [Required]
        [StringLength(12)]
        public string? ShortIdentification { get; set; }

        [Required]
        [StringLength(1)]
        public string? Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartEasterHoliday { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndEasterHoliday { get; set; }

        public int NumberOfClassDays { get; set; }

        [StringLength(1)]
        public string? ScheduleClose { get; set; }

        [StringLength(1)]
        public string? SubjectSelectionClose { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StudentSurveyStart { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StudentSurveyEnd { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StudentsSelectionStart { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StudentsSelectionEnd { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime VacationStart { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime VacationEnd { get; set; }
    }
}