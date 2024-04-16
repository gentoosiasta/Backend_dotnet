using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class CourseTrackingDate
    {
        [Key]
        [ForeignKey("Period")]
        public virtual SchoolPeriod? Period { get; set; }

        [DataType(DataType.Date)]
        public DateOnly ScheduleDeliveryDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly InitialDateFirstTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDateFirstTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly InitialDateSecondTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDateSecondTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly InitialDateThirdTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDateThirdTracking { get; set; }

        [DataType(DataType.Date)]
        public DateOnly InitialDateFinalReport { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDateFinalReport { get; set; }


    }
}