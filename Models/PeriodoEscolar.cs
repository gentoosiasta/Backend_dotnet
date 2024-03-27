using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class PeriodoEscolar
    {
        [Key]
        [StringLength(5)]
        public string? Periodo { get; set; }

        [Required]
        [StringLength(30)]
        public string? IdentificacionLarga { get; set; }

        [Required]
        [StringLength(12)]
        public string? IdentificacionCorta { get; set; }

        [Required]
        [StringLength(1)]
        public string? Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaTermino { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InicioVacacionalSS { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TerminoVacacionalSS { get; set; }

        public int NumDiasClase { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InicioEspecial { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FinEspecial { get; set; }

        [StringLength(1)]
        public string? CierreHorarios { get; set; }

        [StringLength(1)]
        public string? CierreSeleccion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InicioEncEstudiantil { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FinEncEstudiantil { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InicioSeleAlumnos { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FinSeleAlumnos { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InicioVacacional { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TerminoVacacional { get; set; }
    }
}