using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Materia
    {
        [Key]
        [StringLength(7)]
        [Column(name: "Materia")]
        public string? ClaveMateria { get; set; }

        [Required]
        [StringLength(1)]
        public string? NivelEscolar { get; set; }

        public int TipoMateria { get; set; }

        [StringLength(6)]
        public string? ClaveArea { get; set; }

        [Required]
        [StringLength(100)]
        public string? NombreCompletoMateria { get; set; }

        [Required]
        [StringLength(30)]
        public string? NombreAbreviadoMateria { get; set; }
    }
}