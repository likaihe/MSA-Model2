namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletcomment2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "MoviesId", "dbo.Movies");
            DropIndex("dbo.Comments", new[] { "MoviesId" });
            DropTable("dbo.Comments");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Comments", "MoviesId");
            AddForeignKey("dbo.Comments", "MoviesId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
