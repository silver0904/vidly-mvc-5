namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'49306c9b-99b7-4436-8daf-46ecfe36d85f', N'guest@vidly.com', 0, N'AIcppf9a7yk+DE5ecuEHBnUdZNCPuQqBWtc+WaAIN/XO/snavC3R/TjNCptP6HKQwQ==', N'7b5dd4ae-cdd0-498f-ba84-505985396dc2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd626e521-aa09-47be-a17d-50bafda25e85', N'admin@vidly.com', 0, N'AFF4fDj/Xe3sFEBk5uyg/8KnNpSah8hMZvgXT6i/BqNMSomlK6USwXdT6PnpWcllzw==', N'38aab741-1d54-407e-9384-da3929322190', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'399bd3ce-267a-4b46-93c6-57daf243a31f', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd626e521-aa09-47be-a17d-50bafda25e85', N'399bd3ce-267a-4b46-93c6-57daf243a31f')
");
        }
        
        public override void Down()
        {
        }
    }
}
