namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Billings", "BillingAddress_ID", "dbo.Addresses");
            DropForeignKey("dbo.Billings", "Provider_ID", "dbo.Credit_Card");
            DropIndex("dbo.Billings", new[] { "BillingAddress_ID" });
            DropIndex("dbo.Billings", new[] { "Provider_ID" });
            RenameColumn(table: "dbo.Billings", name: "BillingAddress_ID", newName: "AddressID");
            RenameColumn(table: "dbo.Billings", name: "Provider_ID", newName: "CreditCardID");
            AlterColumn("dbo.Billings", "AddressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Billings", "CreditCardID", c => c.Int(nullable: false));
            CreateIndex("dbo.Billings", "CreditCardID");
            CreateIndex("dbo.Billings", "AddressID");
            AddForeignKey("dbo.Billings", "AddressID", "dbo.Addresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Billings", "CreditCardID", "dbo.Credit_Card", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Billings", "CreditCardID", "dbo.Credit_Card");
            DropForeignKey("dbo.Billings", "AddressID", "dbo.Addresses");
            DropIndex("dbo.Billings", new[] { "AddressID" });
            DropIndex("dbo.Billings", new[] { "CreditCardID" });
            AlterColumn("dbo.Billings", "CreditCardID", c => c.Int());
            AlterColumn("dbo.Billings", "AddressID", c => c.Int());
            RenameColumn(table: "dbo.Billings", name: "CreditCardID", newName: "Provider_ID");
            RenameColumn(table: "dbo.Billings", name: "AddressID", newName: "BillingAddress_ID");
            CreateIndex("dbo.Billings", "Provider_ID");
            CreateIndex("dbo.Billings", "BillingAddress_ID");
            AddForeignKey("dbo.Billings", "Provider_ID", "dbo.Credit_Card", "ID");
            AddForeignKey("dbo.Billings", "BillingAddress_ID", "dbo.Addresses", "ID");
        }
    }
}
