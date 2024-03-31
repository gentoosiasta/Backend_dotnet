using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("centros_trabajo")]
    public class CentroTrabajo
    {
        [Key]
        [StringLength(10)]
        [Column(name: "clave_centro_seit")]
        public string? ClaveCentroSeit { get; set; }

        [StringLength(1)]
        [Column(name: "zona_economica")]
        public string? ZonaEconomica { get; set; }

        [ForeignKey("EntidadFederativaId")]
        [Column(name: "entidad_federativa")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; }

        [Required]
        [StringLength(2)]
        [Column(name: "centro_trabajo")]
        public string? ClaveCentroTrabajo { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "nombre_ct")]
        public string? NombreCentroTrabajo { get; set; }

        [StringLength(60)]
        [Column(name: "domicilio_ct")]
        public string? DomicilioCentroTrabajo { get; set; }

        [StringLength(40)]
        [Column(name: "colonia_ct")]
        public string? ColoniaCentroTrabajo { get; set; }

        [Column(name: "codigo_postal_ct")]
        public int CodigoPostalCentroTrabajo { get; set; }

        [StringLength(10)]
        [Column(name: "telefono_ct")]
        public string? TelefonoCentroTrabajo { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_fundacion")]
        public DateOnly? FechaFundacion { get; set; }
    }
}