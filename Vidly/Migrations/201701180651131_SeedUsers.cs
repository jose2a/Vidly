namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e16746c-9579-4f60-bac1-fdc5019f00d7', N'admin@vidly.com', 0, N'AMxe6Muovuh8WPyzIBvpu9jhV3weR65HX2uDGKLsvzwvMwgRURGHQjuUepce9YtNoA==', N'1a98aeb2-7606-44e1-a97a-691712ba7c6b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'74abadf9-6656-414e-b7ca-91729e43e6cd', N'guest@vidly.com', 0, N'ALr2kct6vU8FnIZhyx5UgtdUUiRv/x1eNES/+56AYMoyqLSVtA/QFxR78+LcS+bIYQ==', N'fe98797c-d6a7-46ab-a8ef-b6d022f56443', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'873285a1-ae3c-4f22-b766-60e3a5e4f972', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1e16746c-9579-4f60-bac1-fdc5019f00d7', N'873285a1-ae3c-4f22-b766-60e3a5e4f972')
");
        }
        
        public override void Down()
        {
        }
    }
}
