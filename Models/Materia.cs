using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("materias")]
    public class Materia
    {
        [Key]
        [StringLength(7)]
        [Column(name: "materia")]
        public string? ClaveMateria { get; set; }

        [Required]
        [StringLength(1)]
        [Column(name: "nivel_escolar")]
        public string? NivelEscolar { get; set; }

        [Column(name: "tipo_materia")]
        public int TipoMateria { get; set; }

        [StringLength(6)]
        [Column(name: "clave_area")]
        public string? ClaveArea { get; set; }

        [Required]
        [StringLength(100)]
        [Column(name: "nombre_completo_materia")]
        public string? NombreCompletoMateria { get; set; }

        [Required]
        [StringLength(30)]
        [Column(name: "nombre_abreviado_materia")]
        public string? NombreAbreviadoMateria { get; set; }
    }
}