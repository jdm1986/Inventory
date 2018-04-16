namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hoursnumtostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attachment", "AttachmentNum", c => c.String(nullable: false));
            AlterColumn("dbo.Machine", "MachineNum", c => c.String());
            AlterColumn("dbo.Machine", "Hours", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Machine", "Hours", c => c.Int(nullable: false));
            AlterColumn("dbo.Machine", "MachineNum", c => c.Int(nullable: false));
            AlterColumn("dbo.Attachment", "AttachmentNum", c => c.Int(nullable: false));
        }
    }
}
