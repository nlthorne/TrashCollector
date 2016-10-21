namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billingandshippingbullshit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BillingAddresses", "IsBillingAddress", c => c.Boolean(nullable: false));
            AddColumn("dbo.PickupAddresses", "IsPickupAddress", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PickupAddresses", "IsPickupAddress");
            DropColumn("dbo.BillingAddresses", "IsBillingAddress");
        }
    }
}
