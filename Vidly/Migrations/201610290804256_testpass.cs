namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testpass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "DateReturned");
        }
    }
}
