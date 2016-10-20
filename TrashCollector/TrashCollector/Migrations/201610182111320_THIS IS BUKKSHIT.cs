namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class THISISBUKKSHIT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillingAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PickupAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Addresses", "CityID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "StateID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "ZipCodeID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "CountryID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "PickupAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "BillingAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Billings", "Credit_CardID", c => c.Int(nullable: false));
            AddColumn("dbo.Billings", "Online_MethodsID", c => c.Int(nullable: false));
            AddColumn("dbo.Credit_Card", "BillingAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PickupAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Pickup_TimesID", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "BillingID", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "RouteID", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "Pickup_TimesID", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "Pickup_AddressID", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "CityID");
            CreateIndex("dbo.Addresses", "StateID");
            CreateIndex("dbo.Addresses", "ZipCodeID");
            CreateIndex("dbo.Addresses", "CountryID");
            CreateIndex("dbo.Addresses", "PickupAddressID");
            CreateIndex("dbo.Addresses", "BillingAddressID");
            CreateIndex("dbo.Billings", "Credit_CardID");
            CreateIndex("dbo.Billings", "Online_MethodsID");
            CreateIndex("dbo.Credit_Card", "BillingAddressID");
            CreateIndex("dbo.Customers", "PickupAddressID");
            CreateIndex("dbo.Customers", "Pickup_TimesID");
            CreateIndex("dbo.Customers", "BillingID");
            CreateIndex("dbo.Employees", "RouteID");
            CreateIndex("dbo.Routes", "Pickup_TimesID");
            CreateIndex("dbo.Routes", "Pickup_AddressID");
            AddForeignKey("dbo.Addresses", "BillingAddressID", "dbo.BillingAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CityID", "dbo.Cities", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "StateID", "dbo.States", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Credit_Card", "BillingAddressID", "dbo.BillingAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Billings", "Credit_CardID", "dbo.Credit_Card", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Billings", "Online_MethodsID", "dbo.Online_Methods", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "BillingID", "dbo.Billings", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "PickupAddressID", "dbo.PickupAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "Pickup_TimesID", "dbo.Pickup_Times", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Routes", "Pickup_AddressID", "dbo.Addresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Routes", "Pickup_TimesID", "dbo.Pickup_Times", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "RouteID", "dbo.Routes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "RouteID", "dbo.Routes");
            DropForeignKey("dbo.Routes", "Pickup_TimesID", "dbo.Pickup_Times");
            DropForeignKey("dbo.Routes", "Pickup_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Pickup_TimesID", "dbo.Pickup_Times");
            DropForeignKey("dbo.Customers", "PickupAddressID", "dbo.PickupAddresses");
            DropForeignKey("dbo.Customers", "BillingID", "dbo.Billings");
            DropForeignKey("dbo.Billings", "Online_MethodsID", "dbo.Online_Methods");
            DropForeignKey("dbo.Billings", "Credit_CardID", "dbo.Credit_Card");
            DropForeignKey("dbo.Credit_Card", "BillingAddressID", "dbo.BillingAddresses");
            DropForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "StateID", "dbo.States");
            DropForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses");
            DropForeignKey("dbo.Addresses", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Addresses", "BillingAddressID", "dbo.BillingAddresses");
            DropIndex("dbo.Routes", new[] { "Pickup_AddressID" });
            DropIndex("dbo.Routes", new[] { "Pickup_TimesID" });
            DropIndex("dbo.Employees", new[] { "RouteID" });
            DropIndex("dbo.Customers", new[] { "BillingID" });
            DropIndex("dbo.Customers", new[] { "Pickup_TimesID" });
            DropIndex("dbo.Customers", new[] { "PickupAddressID" });
            DropIndex("dbo.Credit_Card", new[] { "BillingAddressID" });
            DropIndex("dbo.Billings", new[] { "Online_MethodsID" });
            DropIndex("dbo.Billings", new[] { "Credit_CardID" });
            DropIndex("dbo.Addresses", new[] { "BillingAddressID" });
            DropIndex("dbo.Addresses", new[] { "PickupAddressID" });
            DropIndex("dbo.Addresses", new[] { "CountryID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeID" });
            DropIndex("dbo.Addresses", new[] { "StateID" });
            DropIndex("dbo.Addresses", new[] { "CityID" });
            DropColumn("dbo.Routes", "Pickup_AddressID");
            DropColumn("dbo.Routes", "Pickup_TimesID");
            DropColumn("dbo.Employees", "RouteID");
            DropColumn("dbo.Customers", "BillingID");
            DropColumn("dbo.Customers", "Pickup_TimesID");
            DropColumn("dbo.Customers", "PickupAddressID");
            DropColumn("dbo.Credit_Card", "BillingAddressID");
            DropColumn("dbo.Billings", "Online_MethodsID");
            DropColumn("dbo.Billings", "Credit_CardID");
            DropColumn("dbo.Addresses", "BillingAddressID");
            DropColumn("dbo.Addresses", "PickupAddressID");
            DropColumn("dbo.Addresses", "CountryID");
            DropColumn("dbo.Addresses", "ZipCodeID");
            DropColumn("dbo.Addresses", "StateID");
            DropColumn("dbo.Addresses", "CityID");
            DropTable("dbo.PickupAddresses");
            DropTable("dbo.BillingAddresses");
        }
    }
}
