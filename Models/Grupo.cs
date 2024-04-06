using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend_dotnet.Models;

namespace Backend_dotnet.Models
{
    [Table("grupos")]
    public class Grupo
    {
        [Key, Column(name: "Periodo", Order = 0)]
        [ForeignKey("Periodo")]
        public virtual PeriodoEscolar? Periodo { get; set; }

        [Key, Column(name: "materia", Order = 1)]
        [ForeignKey("ClaveMateria")]
        public virtual Materia? Materia { get; set; }

        [Key, Column(name: "grupo", Order = 2)]
        [StringLength(3)]
        public string? ClaveGrupo { get; set; }

        [StringLength(1)]
        [Column(name: "estatus_grupo")]
        public string? EstatusGrupo { get; set; }

        [Column(name: "capacidad_grupo")]
        public int CapacidadGrupo { get; set; }
    }
}