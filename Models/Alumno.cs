using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Alumno
    {
        [Key]
        [StringLength(10)]
        public string? NoDeControl { get; set; }

        [Required]
        [StringLength(3)]
        public string? Carrera { get; set; }

        [Required]
        [StringLength(5)]
        public string? Especialidad { get; set; }

        [Required]
        [StringLength(1)]
        public string? NivelEscolar { get; set; }

        [Required]
        public int Semestre { get; set; }

        [StringLength(10)]
        public string? ClaveInterna { get; set; }

        [Required]
        [StringLength(3)]
        public string? Estatus { get; set; }

        [Required]
        [StringLength(1)]
        public string? PlanDeEstudios { get; set; }

        [StringLength(45)]
        public string? ApellidoPaterno { get; set; }

        [StringLength(45)]
        public string? ApellidoMaterno { get; set; }

        [StringLength(35)]
        public string? Nombre { get; set; }

        [StringLength(18)]
        public string? CURP { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(1)]
        public string? Genero { get; set; }

        [StringLength(1)]
        public string? EstadoCivil { get; set; }

        [Required]
        public int TipoIngreso { get; set; }

        [Required]
        [StringLength(5)]
        public string? PeriodoIngresoIT { get; set; }

        [Required]
        [StringLength(5)]
        public string? UltimoPeriodoInscrito { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal PromedioPeriodoAnterior { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal PromedioAritmeticoCalculado { get; set; }

        public int CreditosAprobados { get; set; }

        public int CreditosCursados { get; set; }

        public decimal PromedioFinalAlcanzado { get; set; }

        [StringLength(1)]
        public string? TipoServicioMedico { get; set; }

        [StringLength(20)]
        public string? ClaveServicioMedico { get; set; }

        [Required]
        [StringLength(50)]
        public string? EscuelaProcedencia { get; set; }

        public int TipoEscuela { get; set; }

        [StringLength(60)]
        public string? DomicilioEscuela { get; set; }

        [Required]
        public int EntidadProcedencia { get; set; }

        [Required]
        [StringLength(30)]
        public string? CiudadProcedencia { get; set; }

        [StringLength(60)]
        public string? CorreoElectronico { get; set; }

        public Byte[]? Foto { get; set; }

        public Byte[]? Firma { get; set; }

        public int PeriodosRevalidacion { get; set; }

        [Column(TypeName = "decimal(8, 6)")]
        public decimal IndiceReprobacionAcumulado { get; set; }

        [StringLength(100)]
        public string? BecadoPor { get; set; }

        public int NIP { get; set; }

        [StringLength(2)]
        public string? TipoAlumno { get; set; }

        [StringLength(3)]
        public string? Nacionalidad { get; set; }

        [StringLength(30)]
        public string? Usuario { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Creado { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Actualizado { get; set; }
    }
}