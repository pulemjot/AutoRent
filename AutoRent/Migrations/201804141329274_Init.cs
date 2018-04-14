namespace AutoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegNumber = c.String(nullable: false),
                        Vendor = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        GearUnitType = c.Int(nullable: false),
                        RentPricePerDay = c.Double(nullable: false),
                        ClientID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClientEntities", t => t.ClientID)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.ClientEntities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PersonalNumber = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CarRents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        LeaseStarted = c.DateTime(nullable: false),
                        LeaseEnded = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CarEntities", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.ClientEntities", t => t.ClientID)
                .Index(t => t.CarID)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.Operators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        HashedPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarEntities", "ClientID", "dbo.ClientEntities");
            DropForeignKey("dbo.CarRents", "ClientID", "dbo.ClientEntities");
            DropForeignKey("dbo.CarRents", "CarID", "dbo.CarEntities");
            DropIndex("dbo.CarRents", new[] { "ClientID" });
            DropIndex("dbo.CarRents", new[] { "CarID" });
            DropIndex("dbo.CarEntities", new[] { "ClientID" });
            DropTable("dbo.Operators");
            DropTable("dbo.CarRents");
            DropTable("dbo.ClientEntities");
            DropTable("dbo.CarEntities");
        }
    }
}
