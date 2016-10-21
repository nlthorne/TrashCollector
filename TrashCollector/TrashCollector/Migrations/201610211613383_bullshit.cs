namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bullshit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "City_ID", "dbo.Cities");
            DropForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "State_ID", "dbo.States");
            DropForeignKey("dbo.Addresses", "ZipCode_ID", "dbo.ZipCodes");
            DropIndex("dbo.Addresses", new[] { "City_ID" });
            DropIndex("dbo.Addresses", new[] { "Country_ID" });
            DropIndex("dbo.Addresses", new[] { "State_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCode_ID" });
            RenameColumn(table: "dbo.Addresses", name: "City_ID", newName: "CityID");
            RenameColumn(table: "dbo.Addresses", name: "Country_ID", newName: "CountryID");
            RenameColumn(table: "dbo.Addresses", name: "State_ID", newName: "StateID");
            RenameColumn(table: "dbo.Addresses", name: "ZipCode_ID", newName: "ZipCodeID");
            AddColumn("dbo.Addresses", "PickupAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "BillingAddressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "CityID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "CountryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "StateID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "ZipCodeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "CityID");
            CreateIndex("dbo.Addresses", "StateID");
            CreateIndex("dbo.Addresses", "ZipCodeID");
            CreateIndex("dbo.Addresses", "CountryID");
            CreateIndex("dbo.Addresses", "PickupAddressID");
            CreateIndex("dbo.Addresses", "BillingAddressID");
            AddForeignKey("dbo.Addresses", "BillingAddressID", "dbo.BillingAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CityID", "dbo.Cities", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "StateID", "dbo.States", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "StateID", "dbo.States");
            DropForeignKey("dbo.Addresses", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses");
            DropForeignKey("dbo.Addresses", "BillingAddressID", "dbo.BillingAddresses");
            DropIndex("dbo.Addresses", new[] { "BillingAddressID" });
            DropIndex("dbo.Addresses", new[] { "PickupAddressID" });
            DropIndex("dbo.Addresses", new[] { "CountryID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeID" });
            DropIndex("dbo.Addresses", new[] { "StateID" });
            DropIndex("dbo.Addresses", new[] { "CityID" });
            AlterColumn("dbo.Addresses", "ZipCodeID", c => c.Int());
            AlterColumn("dbo.Addresses", "StateID", c => c.Int());
            AlterColumn("dbo.Addresses", "CountryID", c => c.Int());
            AlterColumn("dbo.Addresses", "CityID", c => c.Int());
            DropColumn("dbo.Addresses", "BillingAddressID");
            DropColumn("dbo.Addresses", "PickupAddressID");
            RenameColumn(table: "dbo.Addresses", name: "ZipCodeID", newName: "ZipCode_ID");
            RenameColumn(table: "dbo.Addresses", name: "StateID", newName: "State_ID");
            RenameColumn(table: "dbo.Addresses", name: "CountryID", newName: "Country_ID");
            RenameColumn(table: "dbo.Addresses", name: "CityID", newName: "City_ID");
            CreateIndex("dbo.Addresses", "ZipCode_ID");
            CreateIndex("dbo.Addresses", "State_ID");
            CreateIndex("dbo.Addresses", "Country_ID");
            CreateIndex("dbo.Addresses", "City_ID");
            AddForeignKey("dbo.Addresses", "ZipCode_ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.Addresses", "State_ID", "dbo.States", "ID");
            AddForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries", "ID");
            AddForeignKey("dbo.Addresses", "City_ID", "dbo.Cities", "ID");
        }
    }
}
