namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Name");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "DateAdd");
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "GeneresId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GeneresId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
