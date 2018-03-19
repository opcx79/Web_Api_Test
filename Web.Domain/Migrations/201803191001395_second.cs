namespace Web.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tags", "CreatedBy", c => c.String());
            AlterColumn("dbo.Videos", "CreatedBy", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Tags", "CreatedBy", c => c.String(nullable: false));
        }
    }
}
