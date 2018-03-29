namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attachment", "AttachmentMake", c => c.String());
            AlterColumn("dbo.Attachment", "AttachmentModel", c => c.String());
            AlterColumn("dbo.Machine", "MachineMake", c => c.String());
            AlterColumn("dbo.Machine", "MachineModel", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Machine", "MachineModel", c => c.String(nullable: false));
            AlterColumn("dbo.Machine", "MachineMake", c => c.String(nullable: false));
            AlterColumn("dbo.Attachment", "AttachmentModel", c => c.String(nullable: false));
            AlterColumn("dbo.Attachment", "AttachmentMake", c => c.String(nullable: false));
        }
    }
}
