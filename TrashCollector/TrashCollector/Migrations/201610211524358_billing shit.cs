namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billingshit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses");
            DropForeignKey("dbo.Addresses", "ZipCodeID_ID", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "ZipCodeNumber_ID", "dbo.ZipCodes");
            DropForeignKey("dbo.ZipCodes", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Addresses", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "StateID", "dbo.States");
            DropIndex("dbo.Addresses", new[] { "CityID" });
            DropIndex("dbo.Addresses", new[] { "StateID" });
            DropIndex("dbo.Addresses", new[] { "CountryID" });
            DropIndex("dbo.Addresses", new[] { "PickupAddressID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeID_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeNumber_ID" });
            DropIndex("dbo.ZipCodes", new[] { "Address_ID" });
            RenameColumn(table: "dbo.Addresses", name: "CityID", newName: "City_ID");
            RenameColumn(table: "dbo.Addresses", name: "CountryID", newName: "Country_ID");
            RenameColumn(table: "dbo.Addresses", name: "StateID", newName: "State_ID");
            AlterColumn("dbo.Addresses", "City_ID", c => c.Int());
            AlterColumn("dbo.Addresses", "State_ID", c => c.Int());
            AlterColumn("dbo.Addresses", "Country_ID", c => c.Int());
            CreateIndex("dbo.Addresses", "City_ID");
            CreateIndex("dbo.Addresses", "Country_ID");
            CreateIndex("dbo.Addresses", "State_ID");
            AddForeignKey("dbo.Addresses", "City_ID", "dbo.Cities", "ID");
            AddForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries", "ID");
            AddForeignKey("dbo.Addresses", "State_ID", "dbo.States", "ID");
            DropColumn("dbo.Addresses", "PickupAddressID");
            DropColumn("dbo.Addresses", "ZipCodeID_ID");
            DropColumn("dbo.Addresses", "ZipCodeNumber_ID");
            DropColumn("dbo.ZipCodes", "Address_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ZipCodes", "Address_ID", c => c.Int());
            AddColumn("dbo.Addresses", "ZipCodeNumber_ID", c => c.Int());
            AddColumn("dbo.Addresses", "ZipCodeID_ID", c => c.Int());
            AddColumn("dbo.Addresses", "PickupAddressID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Addresses", "State_ID", "dbo.States");
            DropForeignKey("dbo.Addresses", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_ID", "dbo.Cities");
            DropIndex("dbo.Addresses", new[] { "State_ID" });
            DropIndex("dbo.Addresses", new[] { "Country_ID" });
            DropIndex("dbo.Addresses", new[] { "City_ID" });
            AlterColumn("dbo.Addresses", "Country_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "State_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "City_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Addresses", name: "State_ID", newName: "StateID");
            RenameColumn(table: "dbo.Addresses", name: "Country_ID", newName: "CountryID");
            RenameColumn(table: "dbo.Addresses", name: "City_ID", newName: "CityID");
            CreateIndex("dbo.ZipCodes", "Address_ID");
            CreateIndex("dbo.Addresses", "ZipCodeNumber_ID");
            CreateIndex("dbo.Addresses", "ZipCodeID_ID");
            CreateIndex("dbo.Addresses", "PickupAddressID");
            CreateIndex("dbo.Addresses", "CountryID");
            CreateIndex("dbo.Addresses", "StateID");
            CreateIndex("dbo.Addresses", "CityID");
            AddForeignKey("dbo.Addresses", "StateID", "dbo.States", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CityID", "dbo.Cities", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ZipCodes", "Address_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Addresses", "ZipCodeNumber_ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.Addresses", "ZipCodeID_ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.Addresses", "PickupAddressID", "dbo.PickupAddresses", "ID", cascadeDelete: true);
        }
    }
}
