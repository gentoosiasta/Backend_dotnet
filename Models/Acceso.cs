using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Acceso
    {
        [Key]
        [StringLength(30)]
        [Column(name: "usuario")]
        public string? Usuario { get; set; }

        [StringLength(100)]
        [Column(name: "nombre")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(100)]
        [Column(name: "password")]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "email")]
        public string? Email { get; set; }

        [Required]
        [StringLength(3)]
        [Column(name: "tipo_usuario")]
        public string? TipoUsuario { get; set; }

        [Required]
        [StringLength(1)]
        [Column(name: "estatus")]
        public string? Estatus { get; set; }

        [Column(name: "creado")]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Creado { get; set; }

        [Column(name: "actualizado")]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Actualizado { get; set; }
    }
}