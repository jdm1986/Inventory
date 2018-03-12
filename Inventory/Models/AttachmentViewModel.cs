using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class AttachmentViewModel
    {
        public int? AttachmentId { get; set; }

        [DisplayName("Fleet Number")]
        public int? AttachmentNum { get; set; }

        [DisplayName("Make")]
        public string AttachmentMake { get; set; }

        [DisplayName("Model")]
        public string AttachmentModel { get; set; }

        [DisplayName("Type")]
        public int? TypeId { get; set; }

        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DisplayName("Available")]
        public bool Status { get; set; }

        [DisplayName("Attachment")]
        public string AttachmentMakeModel => AttachmentMake + " " + AttachmentModel;

        [DisplayName("Photo URL")]
        public string Photo { get; set; }

        [DisplayName("Type")]
        public string TypeName { get; set; }
    }
}