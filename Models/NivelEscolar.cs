using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("nivel_escolar")]
    public class NivelEscolar
    {
        [Key]
        [StringLength(1)]
        [Column(name: "nivel_escolar")]
        public string? NivelEscolarID { get; set; }

        [Required]
        [StringLength(200)]
        [Column(name: "descripcion_nivel")]
        public string? DescripcionNivel { get; set; }
    }
}