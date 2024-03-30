using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("carreras")]
    public class Carrera
    {
        [Key]
        [StringLength(3)]
        [Column(name: "clave_carrera")]
        public string? ClaveCarrera { get; set; }

        [Column(name: "reticula")]
        public int Reticula { get; set; }

        [ForeignKey("NivelEscolarID")]
        [Column(name: "nivel_escolar")]
        public virtual NivelEscolar? NivelEscolar { get; set; }

        [StringLength(20)]
        [Column(name: "clave_oficial")]
        public string? ClaveOficial { get; set; }

        [Required]
        [StringLength(80)]
        [Column(name: "nombre_carrera")]
        public string? NombreCarrera { get; set; }

        [Required]
        [StringLength(30)]
        [Column(name: "nombre_reducido")]
        public string? NombreReducido { get; set; }

        [Required]
        [StringLength(10)]
        [Column(name: "siglas")]
        public string? Siglas { get; set; }

        [Column(name: "carga_maxima")]
        public int CargaMaxima { get; set; }

        [Column(name: "carga_minima")]
        public int CargaMinima { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_inicio")]
        public DateOnly FechaInicio { get; set; }

        [DataType(DataType.Date)]
        [Column(name: "fecha_termino")]
        public DateOnly FechaTermino { get; set; }

        [StringLength(2)]
        [Column(name: "clave_cosnet")]
        public string? ClaveCosnet { get; set; }

        [Column(name: "creditos_totales")]
        public int CreditosTotales { get; set; }

        [StringLength(1)]
        [Column(name: "modalidad")]
        public string? Modalidad { get; set; }

        [StringLength(1)]
        [Column(name: "estatus")]
        public string? Estatus { get; set; }
    }
}