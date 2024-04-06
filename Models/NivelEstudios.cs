using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("nivel_de_estudios")]
    public class NivelEstudios
    {
        [Key]
        [StringLength(1)]
        [Column(name: "nivel_de_estudios")]
        public string? NivelDeEstudios { get; set; }

        [Required]
        [StringLength(100)]
        [Column(name: "descripcion_nivel_estudios")]
        public string? Descripcion { get; set; }
    }
}