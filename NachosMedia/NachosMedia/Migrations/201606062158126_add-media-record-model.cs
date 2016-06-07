namespace NachosMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmediarecordmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MediaRecords",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        IsPublic = c.Boolean(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        Category_Id = c.Int(),
                        Format_Id = c.Int(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Formats", t => t.Format_Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Format_Id)
                .Index(t => t.Genre_Id);
            
            AddColumn("dbo.AspNetUsers", "MediaRecord_Id", c => c.Guid());
            CreateIndex("dbo.AspNetUsers", "MediaRecord_Id");
            AddForeignKey("dbo.AspNetUsers", "MediaRecord_Id", "dbo.MediaRecords", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "MediaRecord_Id", "dbo.MediaRecords");
            DropForeignKey("dbo.MediaRecords", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.MediaRecords", "Format_Id", "dbo.Formats");
            DropForeignKey("dbo.MediaRecords", "Category_Id", "dbo.Categories");
            DropIndex("dbo.AspNetUsers", new[] { "MediaRecord_Id" });
            DropIndex("dbo.MediaRecords", new[] { "Genre_Id" });
            DropIndex("dbo.MediaRecords", new[] { "Format_Id" });
            DropIndex("dbo.MediaRecords", new[] { "Category_Id" });
            DropColumn("dbo.AspNetUsers", "MediaRecord_Id");
            DropTable("dbo.MediaRecords");
        }
    }
}
