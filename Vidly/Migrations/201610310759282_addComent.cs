namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addComent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        comment = c.String(),
                        Movies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movies_Id)
                .Index(t => t.Movies_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Movies_Id", "dbo.Movies");
            DropIndex("dbo.Comments", new[] { "Movies_Id" });
            DropTable("dbo.Comments");
        }
    }
}
