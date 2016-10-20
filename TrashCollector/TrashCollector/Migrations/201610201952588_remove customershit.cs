namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecustomershit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "BillingID", "dbo.Billings");
            DropForeignKey("dbo.Customers", "PickupAddressID", "dbo.PickupAddresses");
            DropForeignKey("dbo.Customers", "Pickup_TimesID", "dbo.Pickup_Times");
            DropIndex("dbo.Customers", new[] { "PickupAddressID" });
            DropIndex("dbo.Customers", new[] { "Pickup_TimesID" });
            DropIndex("dbo.Customers", new[] { "BillingID" });
            DropColumn("dbo.Customers", "PickupAddressID");
            DropColumn("dbo.Customers", "Pickup_TimesID");
            DropColumn("dbo.Customers", "BillingID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BillingID", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Pickup_TimesID", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PickupAddressID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "BillingID");
            CreateIndex("dbo.Customers", "Pickup_TimesID");
            CreateIndex("dbo.Customers", "PickupAddressID");
            AddForeignKey("dbo.Customers", "Pickup_TimesID", "dbo.Pickup_Times", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "PickupAddressID", "dbo.PickupAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "BillingID", "dbo.Billings", "ID", cascadeDelete: true);
        }
    }
}
