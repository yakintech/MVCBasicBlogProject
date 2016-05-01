namespace MVCBasicBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EMail = c.String(nullable: false),
                        Password = c.String(),
                        Roles = c.String(),
                        LastLoginDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BlogPost",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CategoryID = c.Int(nullable: false),
                        ImagePath = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RoleNumber = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogPost", "CategoryID", "dbo.Category");
            DropIndex("dbo.BlogPost", new[] { "CategoryID" });
            DropTable("dbo.Role");
            DropTable("dbo.Category");
            DropTable("dbo.BlogPost");
            DropTable("dbo.AdminUser");
        }
    }
}
