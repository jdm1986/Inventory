using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class MachineViewModel
    {
        public int? MachineId { get; set; }

        [DisplayName("Fleet Number")]
        public int? MachineNum { get; set; }

        [DisplayName("Make")]
        public string MachineMake { get; set; }

        [DisplayName("Model")]
        public string MachineModel { get; set; }

        [DisplayName("Hours")]
        public int? Hours { get; set; }

        [DisplayName("Type")]
        public int? TypeId { get; set; }

        [DisplayName("Notes")]
        public string Notes { get; set; }

        [DisplayName("Available")]
        public bool Status { get; set; }

        [DisplayName("Machine")]
        public string MachineMakeModel => MachineMake + " " + MachineModel;

        [DisplayName("Photo URL")]
        public string Photo { get; set; }

        [DisplayName("Type")]
        public string TypeName { get; set; }
    }
}