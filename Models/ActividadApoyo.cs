using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class ActividadApoyo
    {
        [Key]
        [StringLength(10)]
        [Column(name: "actividad")]
        public string? Actividad;

        [Required]
        [StringLength(200)]
        [Column(name: "descripcion_actividad")]
        public string? DescripcionActividad { get; set; }

        [Column(name: "metas")]
        public List<string>? Metas { get; set; }
    }
}