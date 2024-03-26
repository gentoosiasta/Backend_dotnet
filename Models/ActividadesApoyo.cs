using System.ComponentModel.DataAnnotations;

namespace Backend_dotnet.Models
{
    public class ActividadesApoyo
    {
        [Key]
        [StringLength(10)]
        public string? Actividad;

        [Required]
        [StringLength(200)]
        public string? DescripcionActividad { get; set; }

        public List<string>? Metas { get; set; }
    }
}