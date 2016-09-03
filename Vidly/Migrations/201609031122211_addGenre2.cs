namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenre2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdd", c => c.DateTime());
        }
    }
}
