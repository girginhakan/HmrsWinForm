namespace HmrsDeneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        WorkingUnit = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        TcNo = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.String(),
                        MobilePhone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Job = c.String(),
                        EducationStatus = c.String(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropIndex("dbo.Patients", new[] { "UserId" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropTable("dbo.Patients");
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
        }
    }
}
