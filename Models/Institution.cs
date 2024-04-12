using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_dotnet.Models
{
    public class Institution
    {
        [ForeignKey("WorkCenterID")]
        public virtual WorkCenter? WorkCenter { get; set; }

        public Byte[]? Logo { get; set; }
    }
}