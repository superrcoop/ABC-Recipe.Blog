namespace FoodMonk.RecipeBlog.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Ratings = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        RecipeType = c.String(),
                        UserId = c.Int(nullable: false),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.UserProfile_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Diet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        username = c.String(),
                        email = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "UserProfile_Id", "dbo.UserProfiles");
            DropIndex("dbo.Recipes", new[] { "UserProfile_Id" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Recipes");
        }
    }
}
