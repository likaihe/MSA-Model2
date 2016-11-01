namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletcomment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Moives_Id", "dbo.Movies");
            DropIndex("dbo.Comments", new[] { "Moives_Id" });
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
                        Movies_Id = c.String(),
                        Moives_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Comments", "Moives_Id");
            AddForeignKey("dbo.Comments", "Moives_Id", "dbo.Movies", "Id");
        }
    }
}
