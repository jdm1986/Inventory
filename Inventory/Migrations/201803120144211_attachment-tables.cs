namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attachmenttables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attachment",
                c => new
                    {
                        AttachmentId = c.Int(nullable: false, identity: true),
                        AttachmentNum = c.Int(nullable: false),
                        AttachmentMake = c.String(nullable: false),
                        AttachmentModel = c.String(nullable: false),
                        Notes = c.String(),
                        Status = c.Boolean(nullable: false),
                        TypeId = c.Int(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.AttachmentId)
                .ForeignKey("dbo.AttachmentType", t => t.TypeId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.AttachmentType",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attachment", "TypeId", "dbo.AttachmentType");
            DropIndex("dbo.Attachment", new[] { "TypeId" });
            DropTable("dbo.AttachmentType");
            DropTable("dbo.Attachment");
        }
    }
}
