namespace laba_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        HeadCompany = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Year = c.Int(nullable: false),
                        EngineId = c.Int(nullable: false),
                        TiresId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Engines", t => t.EngineId, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.Tires", t => t.TiresId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.ModelId)
                .Index(t => t.ColorId)
                .Index(t => t.EngineId)
                .Index(t => t.TiresId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Name, t.Type }, unique: true, name: "FirstAndSecond");
            
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        FuelType = c.String(nullable: false),
                        FuelCapacity = c.Single(nullable: false),
                        HorsePower = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        DriveUnit = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Name, t.DriveUnit, t.Body }, unique: true, name: "IX_FirstSecondThird");
            
            CreateTable(
                "dbo.Tires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 50),
                        Width = c.Single(nullable: false),
                        Diameter = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Brand, t.Width, t.Diameter }, unique: true, name: "IX_FirstSecondThird");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "TiresId", "dbo.Tires");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Cars", "EngineId", "dbo.Engines");
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Cars", "BrandId", "dbo.Brands");
            DropIndex("dbo.Tires", "IX_FirstSecondThird");
            DropIndex("dbo.Models", "IX_FirstSecondThird");
            DropIndex("dbo.Engines", new[] { "Name" });
            DropIndex("dbo.Colors", "FirstAndSecond");
            DropIndex("dbo.Cars", new[] { "TiresId" });
            DropIndex("dbo.Cars", new[] { "EngineId" });
            DropIndex("dbo.Cars", new[] { "ColorId" });
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropIndex("dbo.Cars", new[] { "BrandId" });
            DropIndex("dbo.Brands", new[] { "Name" });
            DropTable("dbo.Tires");
            DropTable("dbo.Models");
            DropTable("dbo.Engines");
            DropTable("dbo.Colors");
            DropTable("dbo.Cars");
            DropTable("dbo.Brands");
        }
    }
}
