namespace PhoneApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                        URL = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(),
                        Msrp = c.Double(nullable: false),
                        ScreenSize = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        Manufacturer_ManufacturerId = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ManufacturerId)
                .Index(t => t.Manufacturer_ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Manufacturer_ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Phones", new[] { "Manufacturer_ManufacturerId" });
            DropTable("dbo.Phones");
            DropTable("dbo.Manufacturers");
        }
    }
}
