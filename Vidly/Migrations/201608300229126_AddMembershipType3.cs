namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipeType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipeType_Id" });
            RenameColumn(table: "dbo.Customers", name: "MembershipeType_Id", newName: "MembershipeTypeId");
            AlterColumn("dbo.Customers", "MembershipeTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipeTypeId");
            AddForeignKey("dbo.Customers", "MembershipeTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "MebershipeTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MebershipeTypeId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipeTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipeTypeId" });
            AlterColumn("dbo.Customers", "MembershipeTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Customers", name: "MembershipeTypeId", newName: "MembershipeType_Id");
            CreateIndex("dbo.Customers", "MembershipeType_Id");
            AddForeignKey("dbo.Customers", "MembershipeType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
