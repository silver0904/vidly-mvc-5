namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameMovieId : DbMigration
    {
        public override void Up()
        {
            Sql("EXEC sp_rename 'Movies.id', 'Id', 'COLUMN';");
        }
        
        public override void Down()
        {
        }
    }
}
