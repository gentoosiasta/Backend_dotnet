using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        [StringLength(6)]
        [Column(name: "categoria")]
        public string? ClaveCategoria { get; set; }

        [Required]
        [StringLength(200)]
        [Column(name: "descripcion_categoria")]
        public string? DescripcionCategoria { get; set; }

        [Column(name: "horas_categoria")]
        public int HorasCategoria { get; set; }

        [Column(name: "horas_grupo")]
        public int HorasGrupo { get; set; }
    }
}