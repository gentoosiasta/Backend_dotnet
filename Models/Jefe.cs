using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("jefes")]
    public class Jefe
    {
        [Key]
        [StringLength(6)]
        [Column(name: "clave_area")]
        public string? ClaveArea { get; set; }

        [StringLength(200)]
        [Column(name: "descripcion_area")]
        public string? DescripcionArea { get; set; }

        [StringLength(50)]
        [Column(name: "jefe_area")]
        public string? JefeArea { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc")]
        public virtual Personal? RFC { get; set; }
    }
}