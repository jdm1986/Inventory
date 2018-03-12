using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Inventory.Models;

namespace Inventory
{
    public class InventoryContext : DbContext
    {
        public InventoryContext()
            : base("name=Inventory") { }

        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<Models.Machine> Machines { get; set; }
    }
}