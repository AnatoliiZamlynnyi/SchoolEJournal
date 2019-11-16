namespace SchoolCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disciplines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Disciplin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        DisciplinId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplines", t => t.DisciplinId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.DisciplinId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Avatar = c.Binary(),
                        Class = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        DisciplinesID = c.Int(nullable: false),
                        Avatar = c.Binary(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplines", t => t.DisciplinesID, cascadeDelete: true)
                .Index(t => t.DisciplinesID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DisciplinesID", "dbo.Disciplines");
            DropForeignKey("dbo.Ratings", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Ratings", "DisciplinId", "dbo.Disciplines");
            DropIndex("dbo.Teachers", new[] { "DisciplinesID" });
            DropIndex("dbo.Ratings", new[] { "DisciplinId" });
            DropIndex("dbo.Ratings", new[] { "StudentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Ratings");
            DropTable("dbo.Disciplines");
        }
    }
}
