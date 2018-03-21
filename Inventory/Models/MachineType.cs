using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    [Table("MachineType")]
    public class MachineType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }

        [Required]
        public string TypeName { get; set; }

        public ICollection<Machine> Machines { get; set; }

    }
}