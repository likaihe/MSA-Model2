namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeesUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1ee3fc7-6624-4206-8085-50ab78290c39', N'admin@vidly.com', 0, N'ALyEfZwHYVgNBDQdNlVUArE9c2/azW48h3vp4YvCEqPDNKstJy8isyR8jrbudjIzNg==', N'5e1c9ac8-05c1-4f5d-9ee2-94283877258b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c9ae6af5-1858-4fd8-b523-1539b57f96a8', N'Manager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c1ee3fc7-6624-4206-8085-50ab78290c39', N'c9ae6af5-1858-4fd8-b523-1539b57f96a8')

");
        }
        
        public override void Down()
        {
        }
    }
}
