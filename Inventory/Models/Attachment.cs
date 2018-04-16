using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    [Table("Attachment")]
    public class Attachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttachmentId { get; set; }
        //Fleet Number
        [Required]
        public string AttachmentNum { get; set; }

        public string AttachmentMake { get; set; }

        public string AttachmentModel { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; }
        public int? TypeId { get; set; }
        public string Photo { get; set; }


        public virtual AttachmentType AttachmentType { get; set; }
    }
}