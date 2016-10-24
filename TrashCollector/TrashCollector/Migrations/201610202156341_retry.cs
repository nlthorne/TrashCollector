namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class retry : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Credit_Card", "BillingAddressID", "dbo.BillingAddresses");
            DropForeignKey("dbo.Billings", "Credit_CardID", "dbo.Credit_Card");
            DropForeignKey("dbo.Billings", "Online_MethodsID", "dbo.Online_Methods");
            DropIndex("dbo.Billings", new[] { "Credit_CardID" });
            DropIndex("dbo.Billings", new[] { "Online_MethodsID" });
            DropIndex("dbo.Credit_Card", new[] { "BillingAddressID" });
            AddColumn("dbo.Billings", "HasCreditCard", c => c.Boolean(nullable: false));
            AddColumn("dbo.Billings", "HasBillingAddress", c => c.Boolean(nullable: false));
            DropColumn("dbo.Billings", "Credit_CardID");
            DropColumn("dbo.Billings", "Online_MethodsID");
            DropColumn("dbo.Credit_Card", "BillingAddressID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Credit_Card", "BillingAddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Billings", "Online_MethodsID", c => c.Int(nullable: false));
            AddColumn("dbo.Billings", "Credit_CardID", c => c.Int(nullable: false));
            DropColumn("dbo.Billings", "HasBillingAddress");
            DropColumn("dbo.Billings", "HasCreditCard");
            CreateIndex("dbo.Credit_Card", "BillingAddressID");
            CreateIndex("dbo.Billings", "Online_MethodsID");
            CreateIndex("dbo.Billings", "Credit_CardID");
            AddForeignKey("dbo.Billings", "Online_MethodsID", "dbo.Online_Methods", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Billings", "Credit_CardID", "dbo.Credit_Card", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Credit_Card", "BillingAddressID", "dbo.BillingAddresses", "ID", cascadeDelete: true);
        }
    }
}
