using Inventory.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Inventory
{
    public class InventoryContext : IdentityDbContext<ApplicationUser>
    {
        public InventoryContext()
            : base("Inventory", throwIfV1Schema: false)
        {
        }

        public static InventoryContext Create()
        {
            return new InventoryContext();
        }
        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<Models.Machine> Machines { get; set; }
        public virtual DbSet<AttachmentType> AttachmentTypes { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
    }
}