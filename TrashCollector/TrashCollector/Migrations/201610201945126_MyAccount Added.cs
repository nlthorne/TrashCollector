namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyAccountAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "First_Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Last_Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Last_Name", c => c.String());
            AlterColumn("dbo.Employees", "First_Name", c => c.String());
        }
    }
}
