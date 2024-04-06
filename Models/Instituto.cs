using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    [Table("instituto")]
    public class Instituto
    {
        [Key]
        [StringLength(10)]
        [Column("clave_centro_seit")]
        public string? ClaveCentroSeit { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_director")]
        public virtual Personal? RfcDirector { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_subadmvo")]
        public virtual Personal? RfcSubdirectorAdmvo { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_subacademico")]
        public virtual Personal? RfcSubdirectorAcademico { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_subplaneacion")]
        public virtual Personal? RfcSubdirectorPlaneacion { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_jrechum")]
        public virtual Personal? RfcJefeRecursosHumanos { get; set; }

        [ForeignKey("RFC")]
        [Column(name: "rfc_jescolares")]
        public virtual Personal? RfcJefeEscolares { get; set; }

        [StringLength(50)]
        [Column(name: "director_per_seit")]
        public string? DirectorPersonalSeit { get; set; }

        [Column(name: "firma_per_seit")]
        public Byte[]? FirmaDirPerSeit { get; set; }

        [StringLength(50)]
        [Column(name: "director_dgit")]
        public string? DirectorDGIT { get; set; }

        [Column(name: "firma_dgit")]
        public Byte[]? FirmaDirDgit { get; set; }

        [Column(name: "logo")]
        public Byte[]? Logo { get; set; }
    }
}