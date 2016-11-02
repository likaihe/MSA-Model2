namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Comment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Comment", c => c.String());
        }
    }
}
