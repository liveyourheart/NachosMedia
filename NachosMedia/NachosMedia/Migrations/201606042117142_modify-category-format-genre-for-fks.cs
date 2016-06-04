namespace NachosMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifycategoryformatgenreforfks : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Formats");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Categories", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Formats", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Formats", "CategoryId", c => c.Int());
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Genres", "CategoryId", c => c.Int());
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Formats", "Id");
            AddPrimaryKey("dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Genres");
            DropPrimaryKey("dbo.Formats");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Genres", "CategoryId", c => c.Byte());
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Formats", "CategoryId", c => c.Byte());
            AlterColumn("dbo.Formats", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Categories", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            AddPrimaryKey("dbo.Formats", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
        }
    }
}
