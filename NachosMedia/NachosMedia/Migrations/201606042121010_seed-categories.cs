namespace NachosMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedcategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories VALUES (1, 'BOARD GAMES')");
            Sql("INSERT INTO Categories VALUES (2, 'BOOKS')");
            Sql("INSERT INTO Categories VALUES (3, 'COMICS')");
            Sql("INSERT INTO Categories VALUES (4, 'MOVIES')");
            Sql("INSERT INTO Categories VALUES (5, 'MUSIC')");
            Sql("INSERT INTO Categories VALUES (6, 'TV')");
            Sql("INSERT INTO Categories VALUES (7, 'VIDEO GAMES')");
            Sql("INSERT INTO Categories VALUES (8, 'OTHER')");
        }
        
        public override void Down()
        {
        }
    }
}
