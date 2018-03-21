using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    [Table("Machine")]
    public class Machine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MachineId { get; set; }

        [Required]
        public int MachineNum { get; set; }

        [Required]
        public string MachineMake { get; set; }

        [Required]
        public string MachineModel { get; set; }
        public int Hours { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; }
        public int? TypeId { get; set; }
        public string Photo { get; set; }


        public virtual MachineType MachineType { get; set; }
    }
}