using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("personal")]
    public class Personal
    {
        [Key]
        [StringLength(13)]
        [Column(name: "rfc")]
        public string? RFC { get; set; }

        [ForeignKey("ClaveCentroSeit")]
        [Column(name: "clave_centro_seit")]
        public virtual CentroTrabajo? ClaveCentroTrabajo { get; set; }

        [ForeignKey("ClaveArea")]
        [Column(name: "clave_area")]
        public virtual Jefe? ClaveArea { get; set; }

        [Required]
        [StringLength(18)]
        [Column(name: "curp_empleado")]
        public string? Curp { get; set; }

        [Column(name: "no_tarjeta")]
        public int NumeroTarjeta { get; set; }

        [Required]
        [StringLength(45)]
        [Column(name: "apellidos_empleado")]
        public string? ApellidosEmpleado { get; set; }

        [Required]
        [StringLength(35)]
        [Column(name: "nombres_empleado")]
        public string? NombreEmpleado { get; set; }

        [Column(name: "horas_nombramiento")]
        public int HorasNombramiento { get; set; }

        [StringLength(1)]
        [Column(name: "nombramiento")]
        public string? Nombramiento { get; set; }

        [StringLength(1)]
        [Column(name: "clases")]
        public string? Clases { get; set; }

        [StringLength(6)]
        [Column(name: "ingreso_rama")]
        public string? IngresoRama { get; set; }

        [StringLength(6)]
        [Column(name: "inicio_gobierno")]
        public string? InicioGobierno { get; set; }

        [StringLength(6)]
        [Column(name: "inicio_sep")]
        public string? InicioSep { get; set; }

        [StringLength(6)]
        [Column(name: "inicio_plantel")]
        public string? InicioPlantel { get; set; }

        [StringLength(60)]
        [Column(name: "domicilio_empleado")]
        public string? DomicilioEmpleado { get; set; }

        [StringLength(40)]
        [Column(name: "colonia_empleado")]
        public string? ColoniaEmpleado { get; set; }

        [Column(name: "codigo_postal_empleado")]
        public int CodigoPostalEmpleado { get; set; }

        [StringLength(30)]
        [Column(name: "localidad")]
        public string? Localidad { get; set; }

        [StringLength(10)]
        [Column(name: "telefono_empleado")]
        public string? TelefonoEmpleado { get; set; }

        [StringLength(1)]
        [Column(name: "sexo_empleado")]
        public string? GeneroEmpleado { get; set; }

        [StringLength(1)]
        [Column(name: "estado_civil")]
        public string? EstadoCivil { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_nacimiento")]
        public DateOnly? FechaNacimiento { get; set; }

        [ForeignKey("EntidadFederativa")]
        [Column(name: "lugar_nacimiento")]
        public virtual EntidadFederativa? LugarNacimiento { get; set; }

        [StringLength(50)]
        [Column(name: "institucion_egreso")]
        public string? InstitucionEgreso { get; set; }

        [ForeignKey("NivelDeEstudios")]
        [Column(name: "nivel_estudios")]
        public virtual NivelEstudios? NivelEstudios { get; set; }

        [StringLength(1)]
        [Column(name: "grado_maximo_estudios")]
        public string? GradoMaximoEstudios { get; set; }

        [StringLength(250)]
        [Column(name: "estudios")]
        public string? Estudios { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_termino_estudios")]
        public DateOnly FechaTerminoEstudios { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_titulacion")]
        public DateOnly FechaTitulacion { get; set; }

        [StringLength(15)]
        [Column(name: "cedula_profesional")]
        public string? CedulaProfesional { get; set; }

        [StringLength(50)]
        [Column(name: "especializacion")]
        public string? Especializacion { get; set; }

        [StringLength(60)]
        [Column(name: "idiomas_domina")]
        public string? IdiomasDomina { get; set; }

        [StringLength(2)]
        [Column(name: "estatus_empleado")]
        public string? EstatusEmpleado { get; set; }

        [Column(name: "foto")]
        public Byte[]? Foto { get; set; }

        [Column(name: "firma")]
        public Byte[]? Firma { get; set; }

        [StringLength(60)]
        [Column(name: "correo_electronico")]
        public string? Email { get; set; }

        [StringLength(50)]
        [Column(name: "padre")]
        public string? Padre { get; set; }

        [StringLength(50)]
        [Column(name: "madre")]
        public string? Madre { get; set; }

        [StringLength(50)]
        [Column(name: "conyuge")]
        public string? Conyuge { get; set; }

        [StringLength(100)]
        [Column(name: "hijos")]
        public string? Hijos { get; set; }

        [Column(name: "num_acta")]
        public int NumeroActa { get; set; }

        [Column(name: "num_libro")]
        public int NumeroLibro { get; set; }

        [Column(name: "num_foja")]
        public int NumeroFoja { get; set; }

        [Column(name: "num_ano")]
        public int NumeroAnio { get; set; }

        [StringLength(15)]
        [Column(name: "num_cartilla_smn")]
        public string? CartillaMilitar { get; set; }

        [Column(name: "ano_clase")]
        public int AnioClase { get; set; }

        [ForeignKey("ClaveArea")]
        [Column(name: "area_academica")]
        public virtual Jefe? AreaAcademica { get; set; }
    }
}