namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addComment : DbMigration
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
                        Movies_Id = c.Int(nullable: false),
                        Moives_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Moives_Id)
                .Index(t => t.Moives_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Moives_Id", "dbo.Movies");
            DropIndex("dbo.Comments", new[] { "Moives_Id" });
            DropTable("dbo.Comments");
        }
    }
}
