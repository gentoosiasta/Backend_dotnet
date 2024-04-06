using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("horarios")]
    public class Horario
    {
        [ForeignKey("Periodo")]
        [Column(name: "periodo")]
        public virtual PeriodoEscolar? Periodo { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc")]
        public virtual Personal? RFC { get; set; }
    }
}