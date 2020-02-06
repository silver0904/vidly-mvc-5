namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Id,Name) VALUES (1, 'Action')");
            Sql("Insert into Genres(Id,Name) VALUES (2, 'Comedy')");
            Sql("Insert into Genres(Id,Name) VALUES (3, 'Family')");
            Sql("Insert into Genres(Id,Name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
