namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkoff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Billings", "DueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Billings", "DueDate");
        }
    }
}
