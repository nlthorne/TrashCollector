namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billingtest2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Billings", "BillingAddress_ID", c => c.Int());
            CreateIndex("dbo.Billings", "BillingAddress_ID");
            AddForeignKey("dbo.Billings", "BillingAddress_ID", "dbo.Addresses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Billings", "BillingAddress_ID", "dbo.Addresses");
            DropIndex("dbo.Billings", new[] { "BillingAddress_ID" });
            DropColumn("dbo.Billings", "BillingAddress_ID");
        }
    }
}
