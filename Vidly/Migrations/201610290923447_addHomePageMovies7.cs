namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHomePageMovies7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomePageMovies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Movie1 = c.Int(nullable: false),
                        Movie2 = c.Int(nullable: false),
                        Movie3 = c.Int(nullable: false),
                        Movie4 = c.Int(nullable: false),
                        Movie5 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HomePageMovies");
        }
    }
}
