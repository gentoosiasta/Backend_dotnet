using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet
{
    [Table("entidades_federativas")]
    public class EntidadFederativa
    {
        [Key]
        [Column(name: "entidad_federativa")]
        public int EntidadFederativaId { get; set; }

        [StringLength(50)]
        [Column(name: "nombre_entidad")]
        public string? NombreEntidad { get; set; }

        [StringLength(2)]
        [Column(name: "clave_entidad")]
        public string? ClaveEntidad { get; set; }
    }
}