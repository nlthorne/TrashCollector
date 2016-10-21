namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Billings", "Provider_ID", c => c.Int());
            CreateIndex("dbo.Billings", "Provider_ID");
            AddForeignKey("dbo.Billings", "Provider_ID", "dbo.Credit_Card", "ID");
            DropColumn("dbo.Billings", "HasCreditCard");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Billings", "HasCreditCard", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Billings", "Provider_ID", "dbo.Credit_Card");
            DropIndex("dbo.Billings", new[] { "Provider_ID" });
            DropColumn("dbo.Billings", "Provider_ID");
        }
    }
}
