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
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<Models.Machine> Machines { get; set; }
        public DbSet<AttachmentType> AttachmentTypes { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
    }
}