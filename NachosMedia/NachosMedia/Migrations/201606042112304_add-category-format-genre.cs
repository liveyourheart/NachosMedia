namespace NachosMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcategoryformatgenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        CategoryId = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        CategoryId = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
            DropTable("dbo.Formats");
            DropTable("dbo.Categories");
        }
    }
}
