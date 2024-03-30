using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("periodos_escolares")]
    public class PeriodoEscolar
    {
        [Key]
        [StringLength(5)]
        [Column("periodo")]
        public string? Periodo { get; set; }

        [Required]
        [StringLength(30)]
        [Column(name: "identificacion_larga")]
        public string? IdentificacionLarga { get; set; }

        [Required]
        [StringLength(12)]
        [Column(name: "identificacion_corta")]
        public string? IdentificacionCorta { get; set; }

        [Required]
        [StringLength(1)]
        [Column(name: "estatus")]
        public string? Status { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fecha_inicio")]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fecha_termino")]
        public DateTime FechaTermino { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "inicio_vacacional_ss")]
        public DateTime InicioVacacionalSS { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "termino_vacacional_ss")]
        public DateTime TerminoVacacionalSS { get; set; }

        [Column(name: "num_dias_clase")]
        public int NumDiasClase { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "inicio_especial")]
        public DateTime InicioEspecial { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fin_especial")]
        public DateTime FinEspecial { get; set; }

        [StringLength(1)]
        [Column(name: "ciere_horarios")]
        public string? CierreHorarios { get; set; }

        [StringLength(1)]
        [Column(name: "ciere_seleccion")]
        public string? CierreSeleccion { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "inicio_enc_estudiantil")]
        public DateTime InicioEncEstudiantil { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fin_enc_estudiantil")]
        public DateTime FinEncEstudiantil { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "inicio_sele_alumnos")]
        public DateTime InicioSeleAlumnos { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fin_sele_alumnos")]
        public DateTime FinSeleAlumnos { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "inicio_vacacional")]
        public DateTime InicioVacacional { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "termino_vacacional")]
        public DateTime TerminoVacacional { get; set; }
    }
}