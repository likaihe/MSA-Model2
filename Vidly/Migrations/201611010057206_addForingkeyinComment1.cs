namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForingkeyinComment1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Comments", new[] { "moives_Id" });
            AddColumn("dbo.Comments", "Comments", c => c.String());
            AddColumn("dbo.Comments", "Movies_Id", c => c.String());
            CreateIndex("dbo.Comments", "Moives_Id");
            DropColumn("dbo.Comments", "comment");
            DropColumn("dbo.Comments", "MoviesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "MoviesId", c => c.String());
            AddColumn("dbo.Comments", "comment", c => c.String());
            DropIndex("dbo.Comments", new[] { "Moives_Id" });
            DropColumn("dbo.Comments", "Movies_Id");
            DropColumn("dbo.Comments", "Comments");
            CreateIndex("dbo.Comments", "moives_Id");
        }
    }
}
