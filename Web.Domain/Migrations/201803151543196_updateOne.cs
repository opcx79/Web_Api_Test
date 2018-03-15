namespace Web.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOne : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "TrillerUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Tags", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Tags", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Videos", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Videos", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Videos", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Videos", "CreatedBy", c => c.String());
            AlterColumn("dbo.Videos", "ImageUrl", c => c.String());
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Tags", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tags", "CreatedBy", c => c.String());
            AlterColumn("dbo.Tags", "Name", c => c.String());
            DropColumn("dbo.Videos", "TrillerUrl");
        }
    }
}
