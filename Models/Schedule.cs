using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Schedule
    {
        [ForeignKey("PeriodID")]
        public virtual SchoolPeriod? Period { get; set; }

        [ForeignKey("RFC")]
        public virtual Staff? RFC { get; set; }
    }
}