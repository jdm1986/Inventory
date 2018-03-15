namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Inventory.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Inventory.InventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        
    }
}
