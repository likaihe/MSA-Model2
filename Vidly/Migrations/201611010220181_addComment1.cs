namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addComment1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        Comments = c.String(),
                        MoviesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MoviesId, cascadeDelete: true)
                .Index(t => t.MoviesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "MoviesId", "dbo.Movies");
            DropIndex("dbo.Comments", new[] { "MoviesId" });
            DropTable("dbo.Comments");
        }
    }
}
