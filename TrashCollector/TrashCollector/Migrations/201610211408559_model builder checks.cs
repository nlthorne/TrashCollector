namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelbuilderchecks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes");
            DropIndex("dbo.Addresses", new[] { "ZipCodeID" });
            RenameColumn(table: "dbo.Addresses", name: "ZipCodeID", newName: "ZipCode_ID");
            AddColumn("dbo.Addresses", "ZipCodeID_ID", c => c.Int());
            AddColumn("dbo.Addresses", "ZipCodeNumber_ID", c => c.Int());
            AddColumn("dbo.ZipCodes", "Address_ID", c => c.Int());
            AddColumn("dbo.Customers", "City_ID", c => c.Int());
            AddColumn("dbo.Customers", "Country_ID", c => c.Int());
            AddColumn("dbo.Customers", "Number_ID", c => c.Int());
            AddColumn("dbo.Customers", "State_ID", c => c.Int());
            AddColumn("dbo.Customers", "Street_Name_ID", c => c.Int());
            AddColumn("dbo.Customers", "ZipCode_ID", c => c.Int());
            AlterColumn("dbo.Addresses", "ZipCode_ID", c => c.Int());
            CreateIndex("dbo.Addresses", "ZipCode_ID");
            CreateIndex("dbo.Addresses", "ZipCodeID_ID");
            CreateIndex("dbo.Addresses", "ZipCodeNumber_ID");
            CreateIndex("dbo.ZipCodes", "Address_ID");
            CreateIndex("dbo.Customers", "City_ID");
            CreateIndex("dbo.Customers", "Country_ID");
            CreateIndex("dbo.Customers", "Number_ID");
            CreateIndex("dbo.Customers", "State_ID");
            CreateIndex("dbo.Customers", "Street_Name_ID");
            CreateIndex("dbo.Customers", "ZipCode_ID");
            AddForeignKey("dbo.Addresses", "ZipCodeID_ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.Addresses", "ZipCodeNumber_ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.ZipCodes", "Address_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "City_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "Country_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "Number_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "State_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "Street_Name_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "ZipCode_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Addresses", "ZipCode_ID", "dbo.ZipCodes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ZipCode_ID", "dbo.ZipCodes");
            DropForeignKey("dbo.Customers", "ZipCode_ID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Street_Name_ID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "State_ID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Number_ID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Country_ID", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "City_ID", "dbo.Addresses");
            DropForeignKey("dbo.ZipCodes", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "ZipCodeNumber_ID", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "ZipCodeID_ID", "dbo.ZipCodes");
            DropIndex("dbo.Customers", new[] { "ZipCode_ID" });
            DropIndex("dbo.Customers", new[] { "Street_Name_ID" });
            DropIndex("dbo.Customers", new[] { "State_ID" });
            DropIndex("dbo.Customers", new[] { "Number_ID" });
            DropIndex("dbo.Customers", new[] { "Country_ID" });
            DropIndex("dbo.Customers", new[] { "City_ID" });
            DropIndex("dbo.ZipCodes", new[] { "Address_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeNumber_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeID_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCode_ID" });
            AlterColumn("dbo.Addresses", "ZipCode_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "ZipCode_ID");
            DropColumn("dbo.Customers", "Street_Name_ID");
            DropColumn("dbo.Customers", "State_ID");
            DropColumn("dbo.Customers", "Number_ID");
            DropColumn("dbo.Customers", "Country_ID");
            DropColumn("dbo.Customers", "City_ID");
            DropColumn("dbo.ZipCodes", "Address_ID");
            DropColumn("dbo.Addresses", "ZipCodeNumber_ID");
            DropColumn("dbo.Addresses", "ZipCodeID_ID");
            RenameColumn(table: "dbo.Addresses", name: "ZipCode_ID", newName: "ZipCodeID");
            CreateIndex("dbo.Addresses", "ZipCodeID");
            AddForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes", "ID", cascadeDelete: true);
        }
    }
}
