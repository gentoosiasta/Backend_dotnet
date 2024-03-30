using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Alumno
    {
        [Key]
        [StringLength(10)]
        [Column(name: "no_de_control")]
        public string? NoDeControl { get; set; }

        [Required]
        [StringLength(3)]
        [Column(name: "carrera")]
        public string? Carrera { get; set; }

        [Required]
        [StringLength(5)]
        [Column(name: "especialidad")]
        public string? Especialidad { get; set; }

        [Required]
        [StringLength(1)]
        [Column(name: "nivel_escolar")]
        public string? NivelEscolar { get; set; }

        [Required]
        [Column(name: "semestre")]
        public int Semestre { get; set; }

        [StringLength(10)]
        [Column(name: "clave_interna")]
        public string? ClaveInterna { get; set; }

        [Required]
        [StringLength(3)]
        [Column(name: "estatus_alumno")]
        public string? Estatus { get; set; }

        [Required]
        [StringLength(1)]
        [Column(name: "plan_de_estudios")]
        public string? PlanDeEstudios { get; set; }

        [Required]
        [StringLength(45)]
        [Column(name: "apellido_paterno")]
        public string? ApellidoPaterno { get; set; }

        [StringLength(45)]
        [Column(name: "apellido_materno")]
        public string? ApellidoMaterno { get; set; }

        [Required]
        [StringLength(35)]
        [Column(name: "nombre_alumno")]
        public string? Nombre { get; set; }

        [StringLength(18)]
        [Column(name: "curp_alumno")]
        public string? CURP { get; set; }

        [DataType(DataType.DateTime)]
        [Column(name: "fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(1)]
        [Column(name: "sexo")]
        public string? Genero { get; set; }

        [StringLength(1)]
        [Column(name: "estado_civil")]
        public string? EstadoCivil { get; set; }

        [Required]
        [Column(name: "tipo_ingreso")]
        public int TipoIngreso { get; set; }

        [Required]
        [StringLength(5)]
        [Column(name: "periodo_ingreso_it")]
        public string? PeriodoIngresoIT { get; set; }

        [Required]
        [StringLength(5)]
        [Column(name: "ultimo_periofo_inscrito")]
        public string? UltimoPeriodoInscrito { get; set; }

        [Column(name: "promedio_periodo_anterior", TypeName = "decimal(5, 2)")]
        public decimal PromedioPeriodoAnterior { get; set; }

        [Column(name: "promedio_aritmetico_calculado", TypeName = "decimal(5, 2)")]
        public decimal PromedioAritmeticoCalculado { get; set; }

        [Column(name: "creditos_aprobados")]
        public int CreditosAprobados { get; set; }

        [Column(name: "creditos_cursados")]
        public int CreditosCursados { get; set; }

        [Column(name: "promedio_final_alcanzado", TypeName = "decimal(5, 2)")]
        public decimal PromedioFinalAlcanzado { get; set; }

        [StringLength(1)]
        [Column(name: "tipo_servicio_medico")]
        public string? TipoServicioMedico { get; set; }

        [StringLength(20)]
        [Column(name: "clave_servicio_medico")]
        public string? ClaveServicioMedico { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "escuela_procedencia")]
        public string? EscuelaProcedencia { get; set; }

        [Column(name: "tipo_escuela")]
        public int TipoEscuela { get; set; }

        [StringLength(60)]
        [Column(name: "domicilio_escuela")]
        public string? DomicilioEscuela { get; set; }

        [Required]
        [Column(name: "entidad_procedencia")]
        public int EntidadProcedencia { get; set; }

        [Required]
        [StringLength(30)]
        [Column(name: "ciudad_procedencia")]
        public string? CiudadProcedencia { get; set; }

        [StringLength(60)]
        [Column(name: "correo_electronico")]
        public string? CorreoElectronico { get; set; }

        [Column(name: "foto")]
        public Byte[]? Foto { get; set; }

        [Column(name: "firma")]
        public Byte[]? Firma { get; set; }

        [Column(name: "periodos_revalidacion")]
        public int PeriodosRevalidacion { get; set; }

        [Column(name: "indice_reprobacion_acumulado", TypeName = "decimal(8, 6)")]
        public decimal IndiceReprobacionAcumulado { get; set; }

        [StringLength(100)]
        [Column(name: "becado_por")]
        public string? BecadoPor { get; set; }

        [Column(name: "nip")]
        public int NIP { get; set; }

        [StringLength(2)]
        [Column(name: "tipo_alumno")]
        public string? TipoAlumno { get; set; }

        [StringLength(3)]
        [Column(name: "nacionalidad")]
        public string? Nacionalidad { get; set; }

        [StringLength(30)]
        [Column(name: "usuario")]
        public string? Usuario { get; set; }

        [Column(name: "creado")]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Creado { get; set; }

        [Column(name: "actualizado")]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Actualizado { get; set; }
    }
}