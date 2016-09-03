namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenre1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAdd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
        }
    }
}
