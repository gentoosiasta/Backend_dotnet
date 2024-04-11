using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Institution
    {
        [ForeignKey("WorkcenterID")]
        public virtual Workcenter? Workcenter { get; set; }

        public Byte[]? Logo { get; set; }
    }
}