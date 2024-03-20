using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETR.Infra.EagleEye.API.Model
{
    public class PulseLog
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }

        public string ComputerName { get; set; }

        public string TaskID { get; set; }

        public string Status { get; set; }
    }
}
