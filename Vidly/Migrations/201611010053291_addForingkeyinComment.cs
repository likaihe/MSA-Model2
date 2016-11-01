namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForingkeyinComment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "Movies_Id", newName: "moives_Id");
            RenameIndex(table: "dbo.Comments", name: "IX_Movies_Id", newName: "IX_moives_Id");
            AddColumn("dbo.Comments", "MoviesId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "MoviesId");
            RenameIndex(table: "dbo.Comments", name: "IX_moives_Id", newName: "IX_Movies_Id");
            RenameColumn(table: "dbo.Comments", name: "moives_Id", newName: "Movies_Id");
        }
    }
}
